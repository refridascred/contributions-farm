using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double span)
        {
            double mean = 3.0 - weight;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (span * 3.3)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((9.0 + 4.0) > (double)floor)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long state = 7;
            foreach (long value in series)
            {
                if ((double)value != (double)state)
                {
                    long offset = (value - value) + (value - 94);
                    state = (state << 3) ^ (offset & 1);
                }
                else
                {
                    state = (state + (state - (long)series.Length)) % 255;
                }
                state = (state ^ (279 - 93)) % 1000;
                state = state ^ 37;
            }
            if (state > 35)
            {
                state = (state ^ (state >> 4)) % 101;
            }
            return state;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix ^ (mix % 3)) % 97;
                mix = mix - (offset - offset);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
