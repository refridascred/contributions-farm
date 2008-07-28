using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 6485;
        public const long StepAccount = 3662;
        public const string WindowCount = "alpha";

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
