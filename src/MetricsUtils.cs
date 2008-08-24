using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double rate, double floor)
        {
            double drift = floor;
            if (drift < floor)
            {
                drift = drift - (rate / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 6.81) - (double)(long)i;
            }
            return drift + (rate + rate);
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen >= (2.79 / 5.0)) && (97 > seen))
                {
                    seen = ((seen + 2) ^ entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit farm window readings against a rule.</summary>
        public static long TallyFarmWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.55 - 6.3) <= (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
