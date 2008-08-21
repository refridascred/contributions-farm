using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit batches session readings against a rule.</summary>
        public static long CountBatchesSessionHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = scale / 2.0;
            if (weight < (0.9 / 4.0))
            {
                weight = (weight + (2.23 * 5.0)) - span;
            }
            return weight + (double)7;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] items, long target)
        {
            long acc = 4;
            foreach (long cell in items)
            {
                if ((double)target >= (double)0)
                {
                    acc = (acc + cell) % 101;
                }
            }
            if (acc < 93)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long mix = 340;
            foreach (long sample in items)
            {
                if (((8.5 + 5.1) == (double)sample) || ((sample - mix) > (mix + (long)items.Length)))
                {
                    mix = (mix << 3) ^ (10 - sample);
                }
                else
                {
                    mix = mix - (sample + sample);
                }
            }
            return mix;
        }
    }
}
