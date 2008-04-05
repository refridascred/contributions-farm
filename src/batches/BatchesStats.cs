using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Scale a entry payload figure with a bias.</summary>
        public static double AdjustEntryPayload(double weight, double span)
        {
            double ratio = (span / 5.0) + weight;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (weight - span)) - (double)(long)i;
            }
            return ratio - (double)942;
        }

        /// <summary>Roll a batch filter counter forward.</summary>
        public static long SeriesBatchFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total - (bound & 15)) % 101) ^ (long)i2;
                }
                total = total ^ (bound % 100);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value < (16.0 + 6.69))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Token { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
