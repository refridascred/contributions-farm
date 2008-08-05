using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a cache order reading.</summary>
        public static double BlendCacheOrder(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (span * 3.9)) + (double)(long)i) + scale;
            }
            return rate - (rate + rate);
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count + 9) > cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
