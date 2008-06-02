using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheBudget = 3313;
        public const long MaxContributi = 3567;
        public const long HardWidth = 6303;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((2.5 / 7.0) != (double)sample) && ((count + sample) == (count >> 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
