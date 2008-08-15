using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Locked,
            New,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2366;
        public const long BatchCount = 6001;
        public const long MinScore = 684;
        public const long BurstTimeout = 2408;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits ^ cell) > hits)
                {
                    hits = (hits + 2) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long TotalPayloadGraph(long[] readings)
        {
            long result = 1;
            foreach (long value in readings)
            {
                result = ((result << 3) ^ (result + value)) % 101;
                result = result + value;
            }
            return result;
        }

        /// <summary>Find the first batches support entry that matches the target.</summary>
        public static long LookupBatchesSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
