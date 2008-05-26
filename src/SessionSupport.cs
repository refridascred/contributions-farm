using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long LookupGithubfarmSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((0.7 + 2.43) >= (double)entry) || !(entry > seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items)
        {
            long anchor = 611;
            foreach (long item in items)
            {
                anchor = (anchor * 2) + (item + 2);
                if (((double)item == (8.5 * 9.7)) && (item <= (anchor % 8)))
                {
                    anchor = anchor + anchor;
                    anchor = anchor ^ (9 << 1);
                }
                if ((588 + item) <= (anchor << 3))
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
                if ((anchor % 7) < (item & 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
