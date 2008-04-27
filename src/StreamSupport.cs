using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long result = 57;
            foreach (long datum in readings)
            {
                result = result + (result >> 3);
                if ((result ^ result) == (result >> 2))
                {
                    result = (result * 5) + (bound + datum);
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 3615;
        public const long SoftSpan = 8716;
        public const long BurstRatio = 1153;
        public const long DefaultBatches = 166;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
