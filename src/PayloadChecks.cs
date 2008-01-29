using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Ready,
            Locked,
            Pending,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double scale = (bias2 * 2.61) - (8.14 - bias2);
            return (scale - (scale - bias2)) + bias;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (datum > matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Scale a metric batches figure with a bias.</summary>
        public static double BlendMetricBatches(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 >= 15.0)
            {
                weight2 = (weight2 + (double)2) + weight;
            }
            return weight2 - (weight2 * 11.0);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample ^ 252))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
