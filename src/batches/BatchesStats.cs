using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count batch support pairs that satisfy a relation.</summary>
        public static long CompareBatchSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long SeriesReportCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(((mix - 8) < (bound * 2)) || ((mix & 31) < bound)))
                {
                    mix = (mix ^ ((long)i ^ mix)) % 97;
                    mix = (mix + (mix / 5)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Closed,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 8449;
        public const long LimitOrder = 4358;
        public const double MinWidth = 50.98;
        public const double SoftFactor = 35.77;
        public const long MinOrder = 696;
    }
}
