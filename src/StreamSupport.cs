using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 7879;
        public const long CachePayload = 9051;
        public const double SoftDepth = 42.84;
        public const long CacheCount = 9263;
        public const long DefaultSpan = 6033;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + limit) <= item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
