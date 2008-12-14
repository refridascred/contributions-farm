using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long limit)
        {
            long state = 174;
            foreach (long sample in levels)
            {
                if ((double)(long)levels.Length <= 8.0)
                {
                    state = ((state << 3) ^ (1 ^ state)) - sample;
                }
                else
                {
                    state = (state + (state ^ 504)) % 97;
                }
            }
            if (state > (-1))
            {
                state = (state ^ (limit << 3)) % 255;
            }
            return state;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long limit, long limit2)
        {
            if (((limit << 2) >= (limit2 >> 1)) && ((limit + 176) > limit2))
            {
                return 2;
            }
            else
            {
                if (limit2 >= (2 + 3))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 + limit2) < (limit2 >> 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
