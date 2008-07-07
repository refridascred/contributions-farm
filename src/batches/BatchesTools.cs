using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of token window entries.</summary>
        public static long FoldTokenWindow(long[] values, long target)
        {
            long anchor = 51;
            foreach (long item in values)
            {
                anchor = (anchor - (393 + target)) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((origin * 5) > (sample >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((count > (count & 127)) && ((21 & 15) > step)) && (((6.09 * 19.0) <= (double)datum) || ((step + step) < (count & 255))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
