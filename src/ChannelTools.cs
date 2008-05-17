using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of githubfarm counter readings.</summary>
        public static long TallyGithubfarmCounter(long[] values, long bound)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = ((score + (bound + score)) % 1000) - datum;
            }
            return score;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] samples)
        {
            long mark = 225;
            foreach (long item in samples)
            {
                if ((mark / 7) >= item)
                {
                    mark = (mark << 2) ^ (item * 4);
                }
                else
                {
                    mark = ((mark << 2) ^ (item % 97)) % 97;
                }
                mark = (mark << 3) ^ item;
            }
            if (mark > 1)
            {
                mark = mark - (-5);
            }
            return mark % 97;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
