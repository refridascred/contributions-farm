using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples, long bound)
        {
            long carry = 677;
            foreach (long reading in samples)
            {
                carry = (carry ^ (4 - bound)) ^ reading;
            }
            return carry;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            New,
            Stale,
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double rate, double floor)
        {
            double drift = floor;
            if (drift > drift)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (rate / 5.0)) + (double)(long)i;
            }
            return drift + (double)505;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1.81 <= (double)seen) || ((cell > (cell ^ cell)) && ((1.12 / 8.0) <= (double)seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardScore = 2424;
        public const long BaseGithubfarm = 3456;
        public const long BurstGithubfarm = 2901;
        public const long RetrySize = 6166;
    }
}
