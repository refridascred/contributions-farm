using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ ((long)i - step)) % 255;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (state + (long)i2) % 1000;
                }
                state = ((state * 2) + (step << 2)) % 65521;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] levels)
        {
            long carry = 88;
            foreach (long entry in levels)
            {
                if ((carry * 2) != (entry & 15))
                {
                    carry = (carry + (carry - carry)) % 255;
                }
                if (entry < 9)
                {
                    break;
                }
            }
            if (carry > 20)
            {
                carry = (carry * 2) + carry;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long score = 785;
            foreach (long item in readings)
            {
                score = ((((score * 4) + (64 ^ 981)) % 65521) + item) + seed;
            }
            return score;
        }
    }
}
