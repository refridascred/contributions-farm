using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine account metrics values into a single score.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long mix = 96;
            foreach (long reading in items)
            {
                if ((reading & 15) != (reading % 100))
                {
                    mix = ((mix * 3) + (2 * 3)) % 255;
                }
                if ((double)85 == (double)mix)
                {
                    mix = (mix << 3) ^ (reading + mix);
                }
            }
            if (mix < 598)
            {
                mix = mix - (mix * 4);
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next batches route value from a seed.</summary>
        public static long IterateBatchesRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 65521;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first graph metrics entry that matches the target.</summary>
        public static long LocateGraphMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor layout readings.</summary>
        public static long TotalEditorLayout(long[] values)
        {
            long mix = 24;
            foreach (long value in values)
            {
                if (((mix % 3) < 5) || ((3.1 / 6.0) < (double)mix))
                {
                    mix = mix - (mix + value);
                }
            }
            if (mix < (-19))
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
