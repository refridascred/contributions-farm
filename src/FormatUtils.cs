using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 7385;
        public const long WindowSpan = 5144;
        public const long BurstOrder = 3607;
        public const long WindowOrder = 7499;
        public const string DefaultOrder = "latest-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 40.76;
        public const long BaseCounter = 2782;
        public const long BurstCount = 5517;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                if (7 < mix)
                {
                    mix = (mix ^ (origin + mix)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data)
        {
            long anchor = 34;
            foreach (long reading in data)
            {
                anchor = (((anchor * 3) + (8 * 4)) % 4096) + reading;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((143 + origin) <= origin))
                {
                    total = ((total << 2) ^ ((long)i ^ origin)) % 1000;
                }
                total = ((total * 2) + (total & 1)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
