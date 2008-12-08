using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long step)
        {
            long next = limit + step;
            if (next > 78)
            {
                return 2;
            }
            else
            {
                if (limit > next)
                {
                    return 1;
                }
                else
                {
                    if ((step - limit) >= step)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)limit == (2.59 - 3.01)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Pending,
            Failed,
            Synced,
            Queued,
        }
    }
}
