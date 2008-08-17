using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (reading < (reading - bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double mean = offset;
            if (mean < (scale / 8.0))
            {
                mean = mean + (double)42;
            }
            else
            {
                mean = mean + (scale + mean);
            }
            return mean + (mean * 14.0);
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Stale,
            Done,
        }
    }
}
