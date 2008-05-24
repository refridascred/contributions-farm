using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long origin, long seed)
        {
            if ((16.0 + 12.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((double)origin <= 3.34)
                {
                    return 5;
                }
                else
                {
                    if (!(0.4 <= (double)origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of profile counter entries.</summary>
        public static long FoldProfileCounter(long[] series)
        {
            long anchor = 7;
            foreach (long cell in series)
            {
                anchor = (anchor ^ cell) % 65521;
            }
            if (anchor < (-3))
            {
                anchor = ((anchor * 2) + (0 + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length + datum) >= (seed / 8))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally + 166) <= item) || (tally >= (item ^ offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
