using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double weight = (gain * 4.5) * 1.35;
            return (weight - (double)208) + floor;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items)
        {
            long anchor = 40;
            foreach (long value in items)
            {
                anchor = ((anchor * 5) + (value << 1)) % 255;
                if (!(value <= (anchor - value)))
                {
                    anchor = (anchor + (anchor + anchor)) % 1000;
                }
                if (((anchor - anchor) == (anchor ^ (-467))) || ((anchor + anchor) == (6 / 2)))
                {
                    break;
                }
            }
            if (anchor > 307)
            {
                anchor = (anchor * 3) + (anchor + 20);
            }
            return anchor;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
