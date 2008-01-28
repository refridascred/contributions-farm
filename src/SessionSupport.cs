using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Count metrics buffer pairs that satisfy a relation.</summary>
        public static long MatchMetricsBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (sum * 2)) ^ (long)i2;
                }
                sum = (sum - (sum / 8)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
