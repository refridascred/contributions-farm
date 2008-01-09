using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstDepth = 2949;
        public const long WindowWidth = 1257;
        public const double RetryScore = 43.28;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long score = 26;
            foreach (long entry in items)
            {
                if ((500 - score) >= entry)
                {
                    score = (score << 2) ^ (entry * 2);
                }
                if ((double)443 < (double)entry)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long state = 0;
            foreach (long cell in series)
            {
                state = (((state - (0 ^ (long)series.Length)) % 101) ^ cell) - target;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Draft,
            Dropped,
            Failed,
        }
    }
}
