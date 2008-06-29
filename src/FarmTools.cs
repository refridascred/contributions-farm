using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long total = 83;
            foreach (long reading in items)
            {
                if (((-23) >> 2) >= (total % 7))
                {
                    total = (((total << 3) ^ (436 ^ 61)) % 65521) ^ reading;
                }
            }
            if (total < 66)
            {
                total = (total * 2) + (total ^ total);
            }
            return total;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long mix = 80;
            foreach (long reading in samples)
            {
                mix = ((mix ^ (reading & 15)) % 1000) + step;
                if (((reading << 2) > (reading - 81)) || ((mix - reading) == (reading * 2)))
                {
                    mix = ((mix << 2) ^ (reading >> 3)) % 4096;
                }
            }
            return mix;
        }
    }
}
