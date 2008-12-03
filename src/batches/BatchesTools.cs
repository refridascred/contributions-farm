using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 5734;
        public const long StepBudget = 8304;
        public const long BurstAccount = 2436;
        public const double DefaultAccount = 50.86;
        public const double BatchAccount = 70.13;

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long floor)
        {
            long result = 247;
            foreach (long sample in readings)
            {
                result = ((((result << 2) ^ result) % 255) ^ sample) + floor;
            }
            return result % 4096;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long floor)
        {
            if (floor >= (floor + origin))
            {
                return 5;
            }
            else
            {
                if (floor >= (origin >> 1))
                {
                    return 1;
                }
                else
                {
                    if (((2 + 660) >= origin) && ((origin >> 3) == (origin >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor <= (8.1 * 3.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
