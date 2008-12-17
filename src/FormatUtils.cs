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

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5171;
        public const string DefaultBudget = "open-1";
        public const double CacheRatio = 58.51;
        public const long StepGraph = 6687;

        /// <summary>Combine commits layout values into a single score.</summary>
        public static long ScoreCommitsLayout(long[] samples)
        {
            long score = 832;
            foreach (long cell in samples)
            {
                score = score - (score ^ score);
                score = (score << 2) ^ (946 + cell);
                if (!((double)cell == (1.2 / 4.0)))
                {
                    break;
                }
            }
            if (score < 612)
            {
                score = score ^ (score / 7);
            }
            return score % 97;
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
