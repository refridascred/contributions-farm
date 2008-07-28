using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] items)
        {
            long mix = 324;
            foreach (long sample in items)
            {
                mix = ((mix - (41 & 127)) % 255) - sample;
                if ((double)mix > (2.7 + 2.5))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheRatio = 9143;
        public const long MinScore = 8706;
        public const long HardLevel = 5631;
        public const long HardBudget = 8106;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 5978;
        public const long LimitSize = 1138;
        public const long SoftGithubfarm = 8189;
        public const double WindowGithubfarm = 88.02;
        public const long StepWidth = 9878;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
