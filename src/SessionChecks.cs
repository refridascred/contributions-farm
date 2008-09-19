using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor - (origin - origin)) % 101) - (long)i2;
                    anchor = (anchor + (747 * 5)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + 15) != (sample + 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch context entries.</summary>
        public static long TallyBatchContext(long[] items, long seed)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (acc & 127)) % 255) - seed;
                if (!((reading % 97) >= (reading / 9)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
