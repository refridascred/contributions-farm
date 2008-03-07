using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double bias, double offset)
        {
            double gain = bias;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (double)(long)i) - offset;
            }
            return gain + (double)64;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Paused,
            Synced,
            Done,
            Locked,
        }

        /// <summary>Digest a series of tools support entries.</summary>
        public static long TallyToolsSupport(long[] series, long step)
        {
            long score = 61;
            foreach (long item in series)
            {
                if ((2 + score) < 15)
                {
                    score = (((score << 3) ^ (item >> 1)) % 65521) - step;
                }
            }
            if (score < 103)
            {
                score = (score + (score << 3)) % 4096;
            }
            return score;
        }
    }
}
