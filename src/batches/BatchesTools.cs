using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long result = 872;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ (322 >> 1)) + cell;
            }
            if (result < 90)
            {
                result = (result * 5) + (result ^ result);
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result % 60);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxFactor = 4092;
        public const long CacheEntry = 3980;
        public const long StepEntry = 2408;
    }
}
