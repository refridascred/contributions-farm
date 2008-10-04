using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((matches < (434 * 2)) || ((double)matches == (9.19 - 20.0))) && (((cell + matches) >= matches) || ((15.0 + 4.0) == (double)matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long step2)
        {
            if ((double)step2 < (double)step)
            {
                return 5;
            }
            else
            {
                if (!((step2 * 5) == (9 - step2)))
                {
                    return 0;
                }
                else
                {
                    if (((double)156 < (double)step2) || ((step2 & 255) >= (step + step2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (724 > (step + step2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Queued,
            Locked,
            Draft,
            Stale,
            Closed,
        }
    }
}
