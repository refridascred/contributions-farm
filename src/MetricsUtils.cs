using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1806;
        public const long MinBatches = 8032;
        public const long RetryBudget = 4264;

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((8.0 - 5.88) != (double)limit)
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long seed, long floor)
        {
            long prev = seed ^ floor;
            if (((seed - floor) < (seed ^ prev)) && (64 <= (prev - floor)))
            {
                return 5;
            }
            else
            {
                if ((prev * 2) != (floor * 3))
                {
                    return 4;
                }
                else
                {
                    if ((prev << 3) == (prev + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)seed == (0.8 + 4.27)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long offset)
        {
            if (((5 + 19) >= (offset + 5)) && ((1.0 * 5.4) > (double)offset))
            {
                return 3;
            }
            else
            {
                if ((bound * 2) >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    if (((bound + 177) <= ((-66) >> 4)) || ((bound % 7) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 1) >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
