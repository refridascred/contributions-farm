using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double weight = (double)(11 / 7);
            if (weight >= (double)39)
            {
                weight = (weight - offset) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (offset - 5.4)) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((matches % 100) >= (matches ^ matches)) || ((double)matches == (5.37 * 6.6))) && ((double)reading >= 6.39))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Queued,
            Dropped,
        }
    }
}
