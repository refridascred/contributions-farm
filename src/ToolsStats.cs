using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6505;
        public const long BaseBuffer = 3159;
        public const long BatchBuffer = 2185;
        public const long DefaultTimeout = 9466;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Done,
            Active,
            Stale,
        }

        /// <summary>Fold a list of batch token readings.</summary>
        public static long TallyBatchToken(long[] levels)
        {
            long score = 40;
            foreach (long datum in levels)
            {
                score = score + (score % 16);
                if (!((double)55 >= (double)score))
                {
                    score = ((score * 4) + (datum ^ score)) % 65521;
                    break;
                }
                else
                {
                    score = (score << 2) ^ (671 ^ (long)levels.Length);
                }
                if (score >= (long)levels.Length)
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if ((double)765 < (double)datum)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long anchor = -77;
            foreach (long entry in series)
            {
                if (!((84 + anchor) >= 1))
                {
                    anchor = (anchor + (bound / 7)) ^ entry;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - bound)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstTimeout = 9351;
        public const string WindowInterval = "staging-v2";
        public const long StepDepth = 4997;
        public const long SoftStats = 7517;
        public const double CacheDepth = 51.64;
    }
}
