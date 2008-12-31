using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double drift = offset + offset;
            if (drift > (offset * 2.8))
            {
                drift = drift - (double)65;
            }
            return drift - ratio;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of account batch entries.</summary>
        public static long WeighAccountBatch(long[] values)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (((mix * 5) + mix) % 65521) - datum;
            }
            return mix % 1000;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)hits < (double)reading) || ((197 * 4) > (hits % 100))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Dropped,
            Idle,
        }
    }
}
