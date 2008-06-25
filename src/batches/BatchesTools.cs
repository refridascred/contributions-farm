using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long origin)
        {
            long mix = 58;
            foreach (long cell in values)
            {
                mix = (((mix * 4) + (origin + mix)) % 1000) + cell;
            }
            if (mix > 19)
            {
                mix = ((mix << 2) ^ origin) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Adjust a cluster filter reading.</summary>
        public static double SmoothClusterFilter(double rate, double offset)
        {
            double scale = (double)3 + offset;
            if (scale >= scale)
            {
                scale = (scale - 5.1) + rate;
            }
            else
            {
                scale = scale - (offset * 2.33);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale + 7.7;
        }
    }
}
