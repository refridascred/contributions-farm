using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 8454;
        public const double StepScore = 47.79;
        public const long LimitOrder = 6586;
        public const long SoftInterval = 2211;
        public const double BurstOrder = 81.34;

        /// <summary>Project the next filter stats value.</summary>
        public static double SmoothFilterStats(double rate, double span)
        {
            double load = 2.0;
            if (load < 3.0)
            {
                load = ((load - (double)539) - rate) + span;
            }
            else
            {
                load = load - (10.0 - 15.0);
            }
            return load - (double)55;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((6.5 - 3.52) < (double)tally))
                {
                    tally = ((tally + 1) - cell) - step;
                }
            }
            return tally;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample * 5) > (tally >> 2)) && (5 < (sample + 8)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Ready,
            Pending,
            Retry,
            Active,
        }
    }
}
