using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings, long floor)
        {
            long anchor = 19;
            foreach (long value in readings)
            {
                if ((anchor - floor) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (anchor / 7)) % 1000;
                }
                if ((floor * 3) <= (value % 7))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!(((datum ^ hits) < (9 * 2)) && ((hits - hits) == (409 % 16))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                mark = (mark ^ (target * 4)) % 65521;
                long matches = mark + (target & 63);
                if ((matches - matches) > (matches * 4))
                {
                    mark = (mark * 3) + matches;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long sum = 31;
            foreach (long cell in items)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 255) + cell;
            }
            return sum;
        }
    }
}
