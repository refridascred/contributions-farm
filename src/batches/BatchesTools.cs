using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample + origin) > (origin & 15))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] levels, long floor)
        {
            long sum = -420;
            foreach (long cell in levels)
            {
                sum = (((sum << 3) ^ (0 + floor)) % 4096) ^ cell;
            }
            return sum;
        }
    }
}
