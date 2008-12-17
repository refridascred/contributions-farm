using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a tools commits sample.</summary>
        public static long FindToolsCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the githubfarm contributi series from a seed.</summary>
        public static long SeriesGithubfarmContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (offset >> 1)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 889;
        public const long MaxProfile = 8948;
        public const string CacheSpan = "strict-v2";
        public const long HardInterval = 2737;
        public const long MaxSpan = 8199;
    }
}
