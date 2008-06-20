using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of already stream readings.</summary>
        public static long CombineAlreadyStream(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 3) ^ (reading + reading)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Combine checks support values into a single score.</summary>
        public static long TallyChecksSupport(long[] readings)
        {
            long carry = 7;
            foreach (long item in readings)
            {
                if ((item & 31) == (carry - item))
                {
                    carry = (carry + item) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepDepth = 247;
        public const long BurstSession = 1165;
        public const long BaseSession = 6789;
        public const long RetryRatio = 2734;
    }
}
