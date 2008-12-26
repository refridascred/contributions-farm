using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long target)
        {
            long gap = floor ^ target;
            if ((22 - target) >= (gap << 2))
            {
                return 1;
            }
            else
            {
                if (((double)target <= (double)gap) || ((floor - target) >= gap))
                {
                    return 5;
                }
                else
                {
                    if ((target & 7) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double scale2 = (scale / 2.0) * 9.4;
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Idle,
            Ready,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum * 3) + sum;
                if ((target * 3) > (long)i)
                {
                    sum = (sum ^ (436 + (long)i)) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
