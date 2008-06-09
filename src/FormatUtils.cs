using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryBudget = 2336;
        public const long MaxSize = 9526;
        public const long StepWidth = 4464;
        public const long MinGraph = 2011;
        public const long WindowDepth = 1060;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi window readings.</summary>
        public static long WeighContributiWindow(long[] samples)
        {
            long anchor = 86;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 16)) % 4096) + cell;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] items)
        {
            long score = 59;
            foreach (long sample in items)
            {
                if ((4.94 - 4.77) < (double)sample)
                {
                    score = score - (score << 1);
                }
                else
                {
                    score = (score + ((-41) - 731)) % 255;
                }
            }
            if (score < 6)
            {
                score = ((score * 3) + score) % 1000;
            }
            return score % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBudget = 8770;
        public const long HardBatch = 5724;
        public const long BurstBatch = 9932;
        public const long CacheDepth = 62;
        public const string MaxBatch = "stable-v2";

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultLevel = 64.79;
        public const long BatchSupport = 9303;
        public const long BaseSupport = 6255;
        public const double RetrySupport = 70.85;
    }
}
