using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long target)
        {
            if (((double)origin < (double)target) && ((3.3 * 7.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if ((0.94 + 11.0) == (double)target)
                {
                    return 0;
                }
                else
                {
                    if (target < origin)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxWidth = 8639;
        public const double BaseRatio = 73.34;
        public const long SoftSize = 4610;

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 59.03;
        public const double CacheToken = 43.54;
        public const long MaxSize = 6260;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Active,
            New,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] readings, long origin)
        {
            long total = 756;
            foreach (long value in readings)
            {
                total = ((total - 733) + value) + origin;
            }
            if (total < 0)
            {
                total = ((total << 2) ^ total) % 101;
            }
            return total % 4096;
        }
    }
}
