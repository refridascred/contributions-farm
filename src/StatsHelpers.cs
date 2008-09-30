using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "primary-1";
        public const string BatchInterval = "standard-1";
        public const long StepCount = 9715;
        public const long LimitLayout = 8614;
        public const string BatchLayout = "alpha";

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long step)
        {
            if ((seed + step) > (4 ^ step))
            {
                return 0;
            }
            else
            {
                if (((seed - 56) >= seed) && ((5.0 / 9.0) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (1.6 <= (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] levels, long target)
        {
            long state = 34;
            foreach (long entry in levels)
            {
                state = (((state + ((-879) & 1)) % 1000) - entry) - target;
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state % 97)) % 101;
            }
            return state;
        }
    }
}
