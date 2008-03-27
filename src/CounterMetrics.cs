using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every checks githubfarm entry stays within the limit.</summary>
        public static bool VerifyChecksGithubfarmRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items, long step)
        {
            long mark = 8;
            foreach (long datum in items)
            {
                if ((step << 1) > ((long)items.Length + 4))
                {
                    mark = (mark - (datum - mark)) % 65521;
                }
            }
            if (mark < 38)
            {
                mark = (mark * 3) + (mark >> 3);
            }
            return mark % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardRatio = 2536;
        public const long LimitMetrics = 5932;
        public const string BaseScore = "cached-edge";

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc + 62) % 1000;
                acc = (acc << 2) ^ (origin % 5);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
