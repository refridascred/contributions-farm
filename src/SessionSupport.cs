using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] items, long seed)
        {
            long mark = 715;
            foreach (long entry in items)
            {
                if ((double)5 < (double)mark)
                {
                    mark = ((mark ^ (entry >> 2)) % 1000) + seed;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric session value from a seed.</summary>
        public static long SeriesMetricSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
