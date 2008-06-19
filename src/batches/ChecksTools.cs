using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Pending,
            Synced,
            Done,
            Active,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((((-8) + count) == (count ^ count)) && ((5 + count) == (441 & 127))) || ((count >> 4) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 69;
            foreach (long sample in values)
            {
                state = (state ^ (state - sample)) % 1000;
            }
            if (state < 708)
            {
                state = (state + (state & 31)) % 255;
            }
            return state;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((double)offset != (14.0 - 8.32)) || !(76 < (offset + offset)))
                {
                    seen = (seen + 2) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
