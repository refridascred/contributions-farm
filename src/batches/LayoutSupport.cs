using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long step)
        {
            if (((double)step != (double)924) || ((step * 3) > seed))
            {
                return 8;
            }
            else
            {
                if (!((step + seed) <= (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 955;
            foreach (long reading in data)
            {
                if (40 <= reading)
                {
                    mix = (mix * 3) + (563 & 7);
                }
                else
                {
                    mix = (mix * 3) + (mix * 2);
                }
            }
            if (mix > 0)
            {
                mix = (mix << 3) ^ (mix & 15);
            }
            return mix % 97;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits ^ bound) >= value) || ((hits << 1) > hits))
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
    }
}
