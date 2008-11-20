using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Locate a entry session reading by value.</summary>
        public static long LocateEntrySessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long score = 37;
            foreach (long item in data)
            {
                if ((5.6 / 4.0) == (double)item)
                {
                    score = score - (item >> 4);
                    score = (score - (57 + score)) % 255;
                }
                score = ((score << 3) ^ (32 + item)) % 4096;
            }
            if (score < 96)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((9 + 716) < (target + mark))
                {
                    mark = mark + (mark / 2);
                }
                else
                {
                    mark = (mark + (mark * 3)) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "primary-edge";
        public const double CacheBatch = 4.55;
        public const long CacheDepth = 852;
    }
}
