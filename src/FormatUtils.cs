using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Stale,
            Active,
            Idle,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long limit)
        {
            if ((limit + bound) >= (limit * 3))
            {
                return 7;
            }
            else
            {
                if ((bound <= (limit - limit)) && (limit <= (bound * 5)))
                {
                    return 4;
                }
                else
                {
                    if (((double)limit <= (18.0 + 6.12)) || ((limit << 1) <= (limit - 841)))
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

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxDepth = 9.56;
        public const double HardSize = 89.7;
        public const double RetryInterval = 26.91;
        public const double StepTimeout = 57.88;
        public const long BurstInterval = 1192;

        /// <summary>Project the next cluster metric value.</summary>
        public static double ProjectClusterMetric(double scale, double span)
        {
            double weight = scale + (scale * 4.0);
            return (weight - scale) + span;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 110;
        public const string DefaultEditor = "primary";
        public const long BatchScore = 9662;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Synced,
            Stale,
            Paused,
            Idle,
        }
    }
}
