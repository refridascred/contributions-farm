using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Failed,
            Stale,
            Locked,
        }

        /// <summary>Count the githubfarm layout entries that pass the check.</summary>
        public static long TallyGithubfarmLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen == (7.59 * 9.7))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine support payload values into a single score.</summary>
        public static long FoldSupportPayload(long[] series)
        {
            long carry = 442;
            foreach (long item in series)
            {
                if (!((item ^ 84) >= (item - 921)))
                {
                    carry = (carry + (carry + 7)) % 4096;
                }
                else
                {
                    carry = carry ^ 9;
                }
                if ((carry % 2) == (carry + 17))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
