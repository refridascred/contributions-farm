using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine payload farm values into a single score.</summary>
        public static long TotalPayloadFarm(long[] levels, long origin)
        {
            long sum = 30;
            foreach (long reading in levels)
            {
                sum = (sum * 5) + reading;
                sum = (sum << 3) ^ (origin << 3);
                if ((sum & 63) <= (reading % 97))
                {
                    break;
                }
            }
            return sum;
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
