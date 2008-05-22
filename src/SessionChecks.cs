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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
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
