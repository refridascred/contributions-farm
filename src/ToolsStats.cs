using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 14.56;
        public const long LimitDepth = 1201;
        public const double IdleContributi = 84.89;
        public const string HardSize = "fallback-edge";

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - ((long)i + mark)) % 1000;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Fold a list of support account readings.</summary>
        public static long FoldSupportAccount(long[] samples, long bound)
        {
            long mix = 72;
            foreach (long datum in samples)
            {
                if ((double)mix == (14.0 * 7.6))
                {
                    mix = (((mix * 2) + (1 & 63)) % 255) + datum;
                }
            }
            if (mix < 69)
            {
                mix = (mix - (bound % 12)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] values)
        {
            long anchor = -50;
            foreach (long entry in values)
            {
                if ((anchor - anchor) == (25 + anchor))
                {
                    anchor = (((anchor << 3) ^ anchor) % 1000) ^ entry;
                }
            }
            if (anchor > 52)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }
    }
}
