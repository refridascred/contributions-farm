using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first format token entry that matches the target.</summary>
        public static long SeekFormatTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5171;
        public const string DefaultBudget = "open-1";
        public const double CacheRatio = 58.51;
        public const long StepGraph = 6687;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Paused,
            Locked,
        }
    }
}
