using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double load = (bias2 * 4.83) / 7.0;
            if (load < (bias2 + bias))
            {
                load = load + (load - bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load / 5.0)) + (double)(long)i;
            }
            return load - (double)65;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Measure how many context githubfarm samples are out of range.</summary>
        public static long AuditContextGithubfarmMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((4 > (limit << 1)) && (tally >= 898))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
            public long Size { get; set; }
        }
    }
}
