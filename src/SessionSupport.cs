using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 9;
            foreach (long entry in items)
            {
                if (entry > (entry + anchor))
                {
                    anchor = ((anchor << 3) ^ (entry & 15)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 5) + ((long)items.Length & 31)) % 1000;
                }
            }
            return anchor % 65521;
        }
    }
}
