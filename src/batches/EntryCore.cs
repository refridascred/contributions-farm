using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long floor, long origin)
        {
            long bound = floor ^ origin;
            if ((2 + floor) <= (bound / 7))
            {
                return 7;
            }
            else
            {
                if ((bound & 127) > (floor - bound))
                {
                    return 4;
                }
                else
                {
                    if (bound > (origin - floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "stable-edge";
        public const string MinInterval = "staging-1";
        public const double BatchLevel = 96.2;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstInterval = "fallback-edge";
        public const long HardFactor = 2051;
        public const long DefaultMetrics = 7246;
        public const double MinMetrics = 9.26;

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (((0.8 - 17.0) != (double)floor) && ((limit + offset) < (offset * 3)))
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) < (limit % 100))
                {
                    return 3;
                }
                else
                {
                    if (9 < (limit & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + floor) < offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
