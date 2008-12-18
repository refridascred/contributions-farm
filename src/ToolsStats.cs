using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate filter command samples.</summary>
        public static long CombineFilterCommand(long[] values)
        {
            long mark = 92;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (datum + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Draft,
            Pending,
            Stale,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinLevel = 9920;
        public const double IdleGraph = 33.29;
        public const long RetryGraph = 1614;
        public const long BatchGraph = 1366;

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
