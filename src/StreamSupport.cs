using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long bound)
        {
            long total = 29;
            foreach (long value in series)
            {
                if (!((double)bound != (double)16))
                {
                    total = (total ^ value) % 255;
                }
            }
            return total;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double scale, double span)
        {
            double rate = scale;
            if (rate < (rate / 8.0))
            {
                rate = rate + scale;
            }
            else
            {
                rate = rate + (span - rate);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + 4.8;
        }
    }
}
