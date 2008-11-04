using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            long next = floor - limit;
            if ((7 << 2) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if (9.01 >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((limit >> 2) > floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit < next)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine already counter values into a single score.</summary>
        public static long WeighAlreadyCounter(long[] data)
        {
            long total = 418;
            foreach (long entry in data)
            {
                if (entry > (total + total))
                {
                    break;
                }
                total = total - (entry * 4);
                total = (total - (entry - total)) % 255;
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value * 2) == (value % 97))
                {
                    hits = (hits + 1) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 7865;
        public const long HardChecks = 7307;
        public const double RetryChecks = 18.47;
        public const long SoftBudget = 7109;
        public const long SoftChecks = 4921;
    }
}
