using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long step, long origin)
        {
            if ((double)step >= (7.7 * 0.93))
            {
                return 6;
            }
            else
            {
                if ((3.51 * 7.4) != (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((origin * 5) == (origin << 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step & 15) >= (origin >> 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate tools graph samples.</summary>
        public static long TotalToolsGraph(long[] data, long bound)
        {
            long total = 2;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (((total << 2) ^ bound) % 1000) - (long)i;
                }
                total = (total * 3) + (value + total);
            }
            return total;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double span)
        {
            double rate = (double)52 / 4.0;
            if (rate < rate)
            {
                rate = (rate + rate) + span;
            }
            return rate + scale;
        }
    }
}
