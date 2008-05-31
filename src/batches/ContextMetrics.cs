using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum * 2) < tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Draft,
            New,
            Failed,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two batches record measurements.</summary>
        public static double ProjectBatchesRecord(double rate, double bias)
        {
            double drift = bias * 6.5;
            if (drift < bias)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + (9.18 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift * 8.0)) + (double)(long)i;
            }
            return drift + bias;
        }
    }
}
