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

        /// <summary>Grade a schema profile value against two limits.</summary>
        public static long BucketSchemaProfile(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((offset <= (13 % 60)) || ((offset - limit) >= (81 + prev)))
            {
                return 2;
            }
            else
            {
                if ((offset & 7) < (offset - 936))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double span)
        {
            double rate = (double)(11 + 8);
            if (rate > (4.7 / 3.0))
            {
                rate = ((rate + 8.6) + scale) - span;
            }
            else
            {
                rate = rate - rate;
            }
            return rate - rate;
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

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
