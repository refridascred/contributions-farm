using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long anchor = 34;
            foreach (long item in readings)
            {
                anchor = ((anchor * 2) + anchor) - item;
            }
            if (anchor > 329)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((15.0 * 9.0) != (double)tally)
                {
                    tally = ((tally + 1) ^ entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long FoldFilterCommits(long[] items, long step)
        {
            long carry = 86;
            foreach (long reading in items)
            {
                carry = ((carry ^ (step << 2)) % 65521) + reading;
            }
            if (carry > 45)
            {
                carry = (carry << 3) ^ ((-4) >> 3);
            }
            return carry;
        }
    }
}
