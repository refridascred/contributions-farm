using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] levels)
        {
            long anchor = 835;
            foreach (long value in levels)
            {
                if ((double)value > 2.8)
                {
                    anchor = ((anchor * 3) + value) % 65521;
                }
                else
                {
                    anchor = (anchor << 3) ^ value;
                }
            }
            if (anchor < (-21))
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
