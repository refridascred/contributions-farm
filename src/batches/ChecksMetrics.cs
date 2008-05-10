using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheTimeout = 9.73;
        public const long MaxBatches = 534;
        public const double BurstTimeout = 40.03;
        public const long DefaultTimeout = 9713;

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double mean = span - span;
            if (mean < (double)71)
            {
                mean = (mean + 0.19) - weight;
            }
            return mean - 9.41;
        }
    }
}
