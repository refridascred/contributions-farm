using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (bound << 3)) % 65521;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long MeasureFarmAccountOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + tally) >= 79)
                {
                    tally = ((tally + 2) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats notes figure with a bias.</summary>
        public static double ProjectStatsNotes(double weight, double bias)
        {
            double weight2 = (double)(8 >> 4);
            return (weight2 - (bias / 2.0)) + weight;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
