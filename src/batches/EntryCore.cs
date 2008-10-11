using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long floor, long origin)
        {
            long edge = floor ^ origin;
            if (!((9.0 * 7.3) < (double)edge))
            {
                return 2;
            }
            else
            {
                if ((285 / 5) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((7.23 + 2.0) >= (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series, long offset)
        {
            long score = 94;
            foreach (long sample in series)
            {
                if ((sample ^ sample) <= (43 / 5))
                {
                    score = (score + (sample % 3)) % 1000;
                }
                score = score - (offset - offset);
            }
            return score % 65521;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] items)
        {
            long anchor = 0;
            foreach (long datum in items)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
                if (((long)items.Length >> 4) >= anchor)
                {
                    continue;
                }
                anchor = anchor - datum;
            }
            return anchor;
        }
    }
}
