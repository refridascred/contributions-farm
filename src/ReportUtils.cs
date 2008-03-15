using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a command graph pair into a bucket.</summary>
        public static long ClassifyCommandGraph(long step, long step2)
        {
            if ((step2 % 64) != (step2 << 2))
            {
                return 3;
            }
            else
            {
                if (((step2 + step) < (5 + step)) && (step >= 81))
                {
                    return 8;
                }
                else
                {
                    if (!((double)step2 > (4.0 * 5.9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 * 2) == (621 & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (19.0 * 1.56))
            {
                rate = (rate + (rate / 4.0)) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Synced,
            Paused,
            Stale,
            Idle,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (817 + target);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
