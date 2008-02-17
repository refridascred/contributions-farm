using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = mix + (mix % 12);
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long bound, long target)
        {
            long next = bound ^ target;
            if (!((target % 64) != (target * 5)))
            {
                return 1;
            }
            else
            {
                if ((next % 64) < 528)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
