using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((step - step) > (acc & 1)))
                {
                    acc = acc ^ ((long)i / 2);
                    acc = acc + 891;
                }
                else
                {
                    acc = acc - (3 + 144);
                    acc = (acc - (296 + (long)i)) % 255;
                }
                acc = ((acc << 2) ^ (acc - (-60))) % 1000;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
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
