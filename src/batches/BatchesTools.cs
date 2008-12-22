using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - (long)i) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultTimeout = 1824;
        public const double IdleToken = 84.99;
        public const double BurstToken = 36.99;
        public const long WindowToken = 9893;
        public const string WindowBudget = "local-edge";

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long seed, long offset)
        {
            long next = seed + offset;
            if ((seed << 1) <= (503 >> 1))
            {
                return 3;
            }
            else
            {
                if (next < (seed / 3))
                {
                    return 5;
                }
                else
                {
                    if (((seed & 15) == (next * 4)) || ((seed >> 4) == (offset / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset ^ seed) != (offset - offset))
                        {
                            return 2;
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
