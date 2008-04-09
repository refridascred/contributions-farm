using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + 718) == (hits + entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] series)
        {
            long mix = 19;
            foreach (long sample in series)
            {
                mix = (mix - (sample - mix)) % 101;
            }
            if (mix < 381)
            {
                mix = (mix << 2) ^ (mix & 7);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long offset)
        {
            long sum = 413;
            foreach (long sample in data)
            {
                sum = ((sum ^ (sample / 9)) % 255) - offset;
                if ((sum ^ 4) < (long)data.Length)
                {
                    sum = ((sum * 2) + 614) % 101;
                }
            }
            return sum;
        }
    }
}
