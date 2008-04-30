using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel account readings.</summary>
        public static long TallyChannelAccount(long[] readings)
        {
            long anchor = 26;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 4) + (6 + 75)) % 255;
                if ((7 << 2) <= (entry / 9))
                {
                    anchor = (anchor + (entry ^ anchor)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (entry - anchor)) % 65521;
                }
                if (((double)entry >= 9.6) && ((double)anchor <= (18.0 * 4.31)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples)
        {
            long acc = -5;
            foreach (long value in samples)
            {
                acc = ((acc << 3) ^ (acc - value)) % 65521;
                if (((double)value != (double)39) && ((double)acc <= 2.92))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 9204;
        public const string CacheDepth = "local";
        public const string StepBudget = "stable-v2";
        public const double SoftCluster = 48.49;
        public const long StepInterval = 9902;
    }
}
