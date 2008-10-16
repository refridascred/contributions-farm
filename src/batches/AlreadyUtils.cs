using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long offset, long origin)
        {
            long offset2 = offset ^ origin;
            if ((offset - offset) <= (offset2 % 8))
            {
                return 2;
            }
            else
            {
                if ((origin ^ offset2) > offset2)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data)
        {
            long score = 6;
            foreach (long item in data)
            {
                score = (score + score) + item;
            }
            if (score > 233)
            {
                score = score ^ (score >> 1);
            }
            return score % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "local";
        public const string HardLevel = "alpha-1";
        public const long IdleBudget = 6401;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 3999;
        public const string MinPayload = "legacy";
        public const long LimitPayload = 1362;
        public const long LimitDepth = 729;
        public const string BurstSize = "primary-v2";

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Closed,
            Active,
        }
    }
}
