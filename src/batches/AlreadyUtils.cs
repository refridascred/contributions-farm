using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long step)
        {
            if ((step / 3) != (step / 7))
            {
                return 0;
            }
            else
            {
                if ((double)step == (14.0 / 6.0))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first token contributi entry that matches the target.</summary>
        public static long FindTokenContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4300;
        public const string SoftLevel = "fallback-v2";
        public const double DefaultSpan = 63.38;
        public const long CacheRatio = 3034;
        public const double MinRatio = 91.68;

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long result = 290;
            foreach (long value in items)
            {
                if ((value + result) >= (result % 60))
                {
                    result = ((result << 2) ^ (value + value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Roll a editor record counter forward.</summary>
        public static long StepEditorRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score << 2) ^ (score - score)) % 4096;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
