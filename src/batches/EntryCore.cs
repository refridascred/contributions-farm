using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many queue route samples are out of range.</summary>
        public static long CountQueueRouteGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((count >> 1) != (offset / 6)) || !((datum << 3) <= (offset - (long)samples.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long seed)
        {
            if (!((seed ^ 744) <= step))
            {
                return 3;
            }
            else
            {
                if ((seed & 15) <= (seed >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((step >= 34) || ((step - 16) > (seed << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step <= (seed + step)) || ((double)0 >= (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value != (0.95 / 2.0))
                {
                    seen = (seen + 3) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen + 47) > (seen ^ entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
            public bool Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
