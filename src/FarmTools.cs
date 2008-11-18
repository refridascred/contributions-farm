using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels, long bound)
        {
            long anchor = 531;
            foreach (long item in levels)
            {
                anchor = (((anchor << 3) ^ item) % 1000) - bound;
                if ((item % 8) == (item >> 5))
                {
                    anchor = (anchor * 3) + ((-5) & 15);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item << 3)) % 97;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long AuditFormatCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!(tally >= 5))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }
    }
}
