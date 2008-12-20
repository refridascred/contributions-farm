using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double floor)
        {
            double bias = ratio;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + ratio) + (double)(long)i) + floor;
            }
            return bias + (double)38;
        }

        /// <summary>Digest a series of order filter entries.</summary>
        public static long DigestOrderFilter(long[] series)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = ((anchor + ((long)series.Length % 24)) % 255) + reading;
            }
            return anchor;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
