using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long bound)
        {
            long delta = origin ^ bound;
            if ((11.0 / 5.0) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin >= delta) || ((delta ^ origin) != (2 ^ origin)))
                {
                    return 5;
                }
                else
                {
                    if ((origin * 4) >= (delta ^ 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long MatchWindowGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
