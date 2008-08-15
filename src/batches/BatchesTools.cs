using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] data)
        {
            long result = 5;
            foreach (long entry in data)
            {
                result = result - (result >> 3);
                result = (result * 5) + (result - entry);
            }
            if (result < 9)
            {
                result = ((result * 4) + (result + result)) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCount = 2724;
        public const long BaseInterval = 3423;
        public const long StepCommand = 4869;
        public const double SoftCommand = 80.14;

        /// <summary>Grade a already record value against two limits.</summary>
        public static long RankAlreadyRecord(long seed, long seed2)
        {
            if ((double)seed2 <= (9.3 + 10.0))
            {
                return 0;
            }
            else
            {
                if (((seed + seed) >= (seed2 + seed)) && (seed >= (seed2 + seed2)))
                {
                    return 1;
                }
                else
                {
                    if (((-728) + seed2) != (seed2 ^ seed2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed2 >= (seed % 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
