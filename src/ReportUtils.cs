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

        /// <summary>Scale a already farm figure with a bias.</summary>
        public static double AdjustAlreadyFarm(double bias, double span)
        {
            double mean = 1.5 * 7.0;
            if (mean < (bias - mean))
            {
                mean = (mean + (bias + bias)) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (mean + 3.4)) + (double)(long)i;
            }
            return mean + (mean / 5.0);
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
