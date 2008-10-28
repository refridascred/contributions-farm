using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double ratio, double span)
        {
            double mean = span;
            if (mean < 8.86)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + (span * 19.0);
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!((hits >> 1) >= step))
                {
                    hits = (hits + 3) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
