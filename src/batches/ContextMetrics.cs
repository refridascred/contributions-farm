using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long RankQueueFilter(long step, long seed)
        {
            long gap = step - seed;
            if ((0 % 60) == (gap << 3))
            {
                return 4;
            }
            else
            {
                if (!((double)gap > (8.0 - 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (((seed / 8) >= (gap << 2)) || ((double)step > (6.04 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long span = origin - origin2;
            if ((origin * 3) <= origin)
            {
                return 8;
            }
            else
            {
                if (((origin / 9) <= (origin + span)) && (((-9) + origin2) > span))
                {
                    return 4;
                }
                else
                {
                    if ((origin * 2) == (9 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double bias)
        {
            double drift = (double)970 * 13.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift - drift) + (double)(long)i) + ratio) - bias;
            }
            return drift + drift;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Locked,
            Retry,
            Paused,
            Failed,
        }
    }
}
