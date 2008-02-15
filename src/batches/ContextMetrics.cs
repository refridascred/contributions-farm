using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            New,
            Idle,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up support cluster samples.</summary>
        public static long OverlapSupportClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph batches input into a small class.</summary>
        public static long GradeGraphBatches(long bound, long step)
        {
            long delta = bound ^ step;
            if (((double)step == (2.0 * 7.3)) || ((double)step <= 4.93))
            {
                return 5;
            }
            else
            {
                if (((-49) <= step) && ((13.0 / 2.0) == (double)step))
                {
                    return 2;
                }
                else
                {
                    if ((double)delta <= 16.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)delta <= (double)bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
