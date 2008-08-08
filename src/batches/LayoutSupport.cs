using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxInterval = "latest-v2";
        public const long WindowCounter = 4561;
        public const string StepCounter = "fallback";
        public const long SoftCounter = 1199;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = ((result << 3) ^ (long)i2) % 65521;
                }
                result = ((result << 2) ^ (result & 127)) % 65521;
                if (((double)result < (2.3 + 8.0)) && ((result / 9) <= 1))
                {
                    result = ((result << 3) ^ result) % 65521;
                    continue;
                }
                else
                {
                    result = result ^ ((long)i % 60);
                    result = result - (seed + seed);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 1473;
        public const long DefaultCommits = 3601;
        public const long BaseBudget = 9318;
        public const long RetryCommits = 8131;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Locked,
            Closed,
            New,
            Stale,
            Pending,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
