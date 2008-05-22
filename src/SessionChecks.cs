using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate channel contributi samples.</summary>
        public static long CombineChannelContributi(long[] levels)
        {
            long carry = 67;
            foreach (long cell in levels)
            {
                if (((cell - carry) >= (carry / 3)) || ((carry << 2) == (carry & 7)))
                {
                    carry = carry ^ cell;
                }
            }
            return carry;
        }

        /// <summary>Rank schema token input into a small class.</summary>
        public static long SortSchemaToken(long bound, long step)
        {
            if (!((2 - 866) > (step - bound)))
            {
                return 0;
            }
            else
            {
                if ((step + 41) < bound)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                mix = mix - (mix - value);
                if (!(mix >= (value << 2)))
                {
                    mix = (mix + (mix + mix)) % 255;
                    mix = mix ^ (value / 5);
                }
                if (!((value >> 3) > (mix - mix)))
                {
                    mix = (mix - (value << 2)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Paused,
            Retry,
            Pending,
        }
    }
}
