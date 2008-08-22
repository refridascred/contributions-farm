using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of schema buffer readings.</summary>
        public static long OverlapSchemaBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "standard-v2";
        public const double WindowRecord = 78.08;
        public const double MinRecord = 53.5;
        public const long BaseSpan = 3216;
        public const double IdleRecord = 26.1;

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 20.16;
        public const double RetryNotes = 5.79;
        public const long LimitDepth = 6911;
        public const long BatchNotes = 9227;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) <= (852 ^ cell))
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double span)
        {
            double mean = span;
            if (mean < (double)585)
            {
                mean = (mean + span) - rate;
            }
            return mean + (double)775;
        }
    }
}
