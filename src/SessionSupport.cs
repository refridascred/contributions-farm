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

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8517;
        public const long BaseFilter = 3113;
        public const string IdleSize = "alpha-1";
        public const double CacheBudget = 76.2;
    }
}
