using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of account entry readings.</summary>
        public static long WeighAccountEntry(long[] series)
        {
            long total = 65;
            foreach (long entry in series)
            {
                if (((double)total >= (double)(long)series.Length) || ((entry + entry) <= (total >> 5)))
                {
                    total = total ^ total;
                }
                if (1.2 > (double)entry)
                {
                    break;
                }
            }
            return total;
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
