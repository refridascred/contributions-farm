using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a cache checks pair into a bucket.</summary>
        public static long ClassifyCacheChecks(long origin, long limit)
        {
            if ((double)limit <= 1.5)
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 4))
                {
                    return 3;
                }
                else
                {
                    if (!((5.1 + 5.2) < (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((origin - 44) != (limit * 5)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 7087;
        public const double BurstSession = 25.0;
        public const long StepScore = 6312;
        public const long BaseBudget = 9289;
        public const long BatchWidth = 1817;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            New,
            Idle,
            Retry,
            Stale,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double BlendFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight + 2.45;
            }
            return weight + (offset - 0.56);
        }
    }
}
