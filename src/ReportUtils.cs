using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 38.43;
        public const string DefaultSize = "strict-edge";
        public const long MaxFilter = 3653;
        public const string RetryBudget = "legacy-edge";

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long step, long seed)
        {
            long edge = step - seed;
            if ((edge >> 4) < (step + step))
            {
                return 4;
            }
            else
            {
                if (seed > (edge & 7))
                {
                    return 2;
                }
                else
                {
                    if (((-6) + step) >= (seed + edge))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route report samples are out of range.</summary>
        public static long AuditRouteReportMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(datum < (datum + 8)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Retry,
            Pending,
            Dropped,
        }
    }
}
