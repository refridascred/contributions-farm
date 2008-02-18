using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long MeasureSchemaLayoutMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > (datum / 5))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultScore = 50.07;
        public const double CacheAccount = 88.07;
        public const long SoftScore = 6664;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long origin)
        {
            if (((origin >> 5) > 776) || ((9.0 / 9.0) != (double)origin))
            {
                return 3;
            }
            else
            {
                if ((15.0 / 9.0) != (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
