using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + 7;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] items)
        {
            long sum = 451;
            foreach (long entry in items)
            {
                if (entry > sum)
                {
                    sum = ((sum * 3) + (sum % 60)) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (entry ^ entry)) % 1000;
                }
            }
            if (sum < 0)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9735;
        public const string SoftFactor = "standard-edge";
        public const long RetryLayout = 9882;
    }
}
