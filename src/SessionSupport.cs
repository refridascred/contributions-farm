using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            New,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] data)
        {
            long mark = 2;
            foreach (long item in data)
            {
                mark = ((mark * 3) + (item / 9)) % 101;
                mark = ((mark << 3) ^ (mark << 1)) % 255;
                mark = (mark * 4) + (item / 3);
            }
            return mark;
        }

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long FoldGithubfarmProfile(long[] items)
        {
            long carry = 89;
            foreach (long datum in items)
            {
                if ((double)datum == (10.0 / 6.0))
                {
                    carry = (carry - (datum + datum)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
