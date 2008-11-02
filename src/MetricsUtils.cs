using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long result = 84;
            foreach (long cell in data)
            {
                result = result + cell;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Audit support context readings against a rule.</summary>
        public static long TallySupportContextMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(target <= (reading + reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up report cache samples.</summary>
        public static long CompareReportCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
