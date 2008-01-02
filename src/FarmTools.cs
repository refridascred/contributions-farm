using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples)
        {
            long acc = 43;
            foreach (long cell in samples)
            {
                if ((5 + cell) >= cell)
                {
                    acc = (acc + cell) % 65521;
                }
            }
            return acc;
        }
    }
}
