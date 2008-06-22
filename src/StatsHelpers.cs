using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long offset)
        {
            if ((offset << 3) <= origin)
            {
                return 0;
            }
            else
            {
                if (origin >= (44 % 2))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every session counter entry stays within the limit.</summary>
        public static bool ValidateSessionCounterBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
