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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
