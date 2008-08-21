using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheSize = "standard-edge";
        public const long BurstCache = 9211;
        public const long BurstFactor = 2434;
        public const string CacheScore = "open-v2";

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long limit)
        {
            long cur = offset - limit;
            if (((cur + limit) <= (cur << 2)) && ((double)cur < (4.42 * 1.1)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 2) >= (cur & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double bias, double span)
        {
            double gain = bias;
            if (gain > gain)
            {
                gain = gain + (gain + span);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + 20.0) + (double)(long)i;
            }
            return gain + (span - 6.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double ratio = gain + (bias * 14.0);
            return ratio + (bias * 11.0);
        }
    }
}
