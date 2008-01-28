using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first editor githubfarm entry that matches the target.</summary>
        public static long LocateEditorGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session order entries.</summary>
        public static long FoldSessionOrder(long[] samples, long offset)
        {
            long state = 82;
            foreach (long item in samples)
            {
                state = ((state - item) % 101) - offset;
            }
            return state;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double gain = bias;
            if (gain <= offset)
            {
                gain = gain + (offset - gain);
            }
            return gain + offset;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 4526;
        public const double BaseCommand = 47.47;
        public const double MinCommand = 54.64;
        public const long BurstLevel = 3192;
        public const long CacheBudget = 518;

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long TallyQueueFormatHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((5 << 3) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
