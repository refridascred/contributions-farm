using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long CompareSupportFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Idle,
            Failed,
            New,
            Closed,
            Synced,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double span)
        {
            double weight = gain;
            if (weight >= (span * 8.0))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + span;
            }
            return weight - (weight + gain);
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
