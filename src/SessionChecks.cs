using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseWidth = 79.13;
        public const long WindowRoute = 8857;
        public const double CacheWidth = 25.5;
        public const long BurstRoute = 2065;

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items)
        {
            long result = -86;
            foreach (long datum in items)
            {
                if ((result - datum) >= (datum - result))
                {
                    result = (result + result) % 65521;
                }
                if ((result >> 2) > (2 / 5))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Dropped,
            Failed,
            Locked,
            Draft,
        }

        /// <summary>Iterate the checks context series from a seed.</summary>
        public static long IterateChecksContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                if (((floor - acc) > (floor + (long)i)) || ((long)i < acc))
                {
                    acc = (acc ^ ((long)i + acc)) % 1000;
                    acc = acc + (floor >> 4);
                }
                else
                {
                    acc = (acc - acc) % 4096;
                    acc = acc ^ (floor / 3);
                }
                if (!(acc > (acc << 1)))
                {
                    acc = (acc - (acc + (long)i)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
