using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Retry,
        }

        /// <summary>Check that every route format entry stays within the limit.</summary>
        public static bool ValidateRouteFormatLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (8.7 < (double)(long)i)
                {
                    mark = mark ^ (421 + (long)i);
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
