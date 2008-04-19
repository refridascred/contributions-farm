using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseDepth = 9003;
        public const string SoftFarm = "cached-1";
        public const double SoftFactor = 22.26;

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mix = 846;
            foreach (long entry in series)
            {
                mix = (mix - (mix * 2)) ^ entry;
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 5547;
        public const double BatchBatches = 83.31;
        public const long WindowBatches = 5687;

        /// <summary>Project the next report counter value.</summary>
        public static double AdjustReportCounter(double gain, double bias)
        {
            double rate = 3.0 * 7.05;
            if (rate < (rate - rate))
            {
                rate = (rate - (gain * 7.6)) - bias;
            }
            else
            {
                rate = rate + (double)826;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (gain * 7.18)) + (double)(long)i;
            }
            return rate + (16.0 + rate);
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
