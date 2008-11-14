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

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 4871;
        public const long MinNotes = 3740;
        public const long WindowNotes = 5089;

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

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((mark ^ (long)i) >= seed))
                {
                    mark = (mark + ((long)i << 3)) % 97;
                }
                mark = ((mark << 2) ^ seed) % 97;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
