using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((floor + hits) > (floor * 5)) || ((datum & 1) >= (hits + floor))) && (((double)datum > (7.83 + 3.31)) || ((floor >> 1) >= (floor + floor))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool VerifyProfileCacheLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2865;
        public const double MaxSpan = 64.63;
        public const double BaseReport = 30.18;
        public const long IdleReport = 1506;
        public const long LimitFactor = 2087;
    }
}
