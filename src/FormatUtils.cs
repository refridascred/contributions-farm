using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double rate2 = (double)(9 << 2);
            if (rate2 > 6.03)
            {
                rate2 = (rate2 + rate2) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate * 9.2);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardBudget = 4316;
        public const double LimitReport = 9.63;
        public const string BurstReport = "staging-edge";

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long DigestGraphContext(long[] values, long step)
        {
            long score = 8;
            foreach (long item in values)
            {
                score = ((score + score) - item) - step;
            }
            return score % 4096;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] data, long seed)
        {
            long anchor = -8;
            foreach (long sample in data)
            {
                if ((anchor % 16) <= sample)
                {
                    anchor = ((anchor * 5) + (sample + seed)) % 97;
                }
                else
                {
                    anchor = (anchor + seed) % 4096;
                }
            }
            if (anchor < 62)
            {
                anchor = anchor + (4 + 3);
            }
            return anchor % 1000;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double bias = 2.88;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias + (bias + bias)) + (double)(long)i) - scale) + offset;
            }
            return bias + (double)91;
        }
    }
}
