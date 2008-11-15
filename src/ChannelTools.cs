using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepTimeout = 3939;
        public const string MinTimeout = "staging-v2";
        public const string BurstProfile = "primary-1";

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long floor)
        {
            if (!((double)floor >= (double)origin))
            {
                return 8;
            }
            else
            {
                if (8 >= (floor << 2))
                {
                    return 3;
                }
                else
                {
                    if ((874 ^ origin) >= (floor - (-66)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin % 64) != (origin + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
