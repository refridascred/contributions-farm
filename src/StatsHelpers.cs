using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8006;
        public const double WindowRatio = 48.66;
        public const string BurstCount = "staging";

        /// <summary>Locate a channel batches reading by value.</summary>
        public static long LocateChannelBatchesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchCount = 2.11;
        public const long RetrySchema = 703;
        public const long IdleSize = 3707;

        /// <summary>Audit command record readings against a rule.</summary>
        public static long TallyCommandRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((long)samples.Length < (seen >> 5))
                {
                    seen = (seen + 3) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double floor)
        {
            double rate = (double)(-2) / 8.0;
            if (rate > (bias / 5.0))
            {
                rate = (rate + bias) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)154) + (double)(long)i;
            }
            return rate + (double)(-54);
        }
    }
}
