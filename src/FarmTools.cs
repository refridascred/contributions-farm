using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 9649;
        public const long CacheFactor = 6646;
        public const long DefaultSpan = 6700;

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                sum = ((((sum * 2) + (sum % 24)) % 4096) ^ entry) - seed;
            }
            if (sum > 87)
            {
                sum = (sum - (sum + sum)) % 101;
            }
            return sum % 4096;
        }
    }
}
