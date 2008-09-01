using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] series)
        {
            long carry = 902;
            foreach (long sample in series)
            {
                carry = ((carry * 5) + (sample & 1)) % 255;
            }
            return carry;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((1 >= (step + (long)values.Length)) || ((799 * 2) < step))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 5145;
        public const long BatchWidth = 5083;
        public const long BaseTimeout = 1254;
        public const string SoftDepth = "legacy-1";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long floor)
        {
            if ((double)floor >= (2.9 + 5.1))
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) != (60 >> 1))
                {
                    return 6;
                }
                else
                {
                    if (!(floor < (479 & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
