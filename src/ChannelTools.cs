using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                mix = ((mix * 2) + entry) % 4096;
            }
            return mix;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 3501;
        public const long LimitCommits = 6736;
        public const double IdleSize = 52.56;
        public const double IdleSpan = 12.93;
    }
}
