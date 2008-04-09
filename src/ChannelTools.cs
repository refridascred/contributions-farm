using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] series)
        {
            long score = -2;
            foreach (long cell in series)
            {
                score = (score - cell) % 101;
            }
            if (score < 902)
            {
                score = (score << 3) ^ (score + score);
            }
            return score;
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
