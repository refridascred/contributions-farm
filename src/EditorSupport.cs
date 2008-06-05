using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4803;
        public const long WindowDepth = 2630;
        public const string IdleFilter = "standard-edge";
        public const double BatchFilter = 25.12;

        /// <summary>Adjust a cluster account reading.</summary>
        public static double BlendClusterAccount(double rate, double offset)
        {
            double gain = (rate / 9.0) / 3.0;
            if (gain < offset)
            {
                gain = gain - rate;
            }
            return gain - 7.3;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double mean = (double)202 + (gain / 2.0);
            if (mean <= (gain - 6.64))
            {
                mean = (mean - 3.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (gain + gain);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 2) + (acc - acc);
                acc = acc - (8 + acc);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
