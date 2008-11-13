using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first checks account entry that matches the target.</summary>
        public static long LocateChecksAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3437;
        public const double MinTimeout = 80.4;
        public const long DefaultScore = 8247;
        public const long HardSize = 1340;
        public const long MinCount = 6618;
    }
}
