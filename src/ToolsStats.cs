using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long bound)
        {
            if ((9.82 - 5.66) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((offset - offset) < (bound - bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= (5.24 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double rate, double bias)
        {
            double drift = bias / 6.0;
            if (drift >= (rate + bias))
            {
                drift = drift + (bias - drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (drift + drift);
        }

        /// <summary>Iterate the githubfarm profile series from a seed.</summary>
        public static long SeriesGithubfarmProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum - (step + (long)i2)) % 255;
                    sum = (sum * 5) + (step % 16);
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftDepth = 481;
        public const string RetryProfile = "primary-v2";
        public const long BurstProfile = 1881;
    }
}
