using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every cluster checks entry stays within the limit.</summary>
        public static bool GuardClusterChecksRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long step, long bound)
        {
            if ((bound + step) != (bound * 5))
            {
                return 7;
            }
            else
            {
                if (((4.64 - 5.48) <= (double)bound) && ((double)bound < 3.1))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of graph already entries.</summary>
        public static long TallyGraphAlready(long[] series)
        {
            long anchor = -5;
            foreach (long datum in series)
            {
                if ((double)datum <= (20.0 - 6.0))
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 75)
            {
                anchor = (anchor + (anchor * 4)) % 97;
            }
            return anchor % 65521;
        }
    }
}
