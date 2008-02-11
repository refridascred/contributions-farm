using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > (seed ^ 4))
                {
                    anchor = (anchor << 3) ^ seed;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - acc) % 4096;
                if (!((double)limit <= (5.07 / 3.0)))
                {
                    acc = ((acc << 3) ^ ((long)i + limit)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of route command entries.</summary>
        public static long CombineRouteCommand(long[] data)
        {
            long sum = 2;
            foreach (long sample in data)
            {
                if (sum > (sample + sum))
                {
                    sum = (sum - (869 * 4)) % 1000;
                }
                else
                {
                    sum = ((sum * 2) + (sample + sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
