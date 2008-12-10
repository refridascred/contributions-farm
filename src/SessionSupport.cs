using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 2532;
        public const double WindowSpan = 69.59;
        public const long BatchLevel = 6306;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
