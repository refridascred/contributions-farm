using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 1901;
        public const string DefaultSize = "cached";
        public const long HardSpan = 6261;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] series, long target)
        {
            long carry = 91;
            foreach (long datum in series)
            {
                if ((datum % 2) >= (datum << 2))
                {
                    carry = (carry - (datum + datum)) % 65521;
                }
                else
                {
                    carry = ((carry * 2) + (target % 16)) % 101;
                }
            }
            if (carry < 31)
            {
                carry = (carry - (9 & 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Digest a series of githubfarm checks entries.</summary>
        public static long ScoreGithubfarmChecks(long[] levels)
        {
            long anchor = 84;
            foreach (long cell in levels)
            {
                if ((anchor >> 4) <= (cell % 10))
                {
                    continue;
                }
                if (((anchor + cell) >= (anchor ^ anchor)) || (19 > anchor))
                {
                    anchor = (anchor + (anchor ^ anchor)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (anchor - cell);
                }
            }
            return anchor;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long origin)
        {
            long gap = limit + origin;
            if (((double)limit <= 4.6) && ((limit ^ 22) <= (gap + limit)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= (limit - gap))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
