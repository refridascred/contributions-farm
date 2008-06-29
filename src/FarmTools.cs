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

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
