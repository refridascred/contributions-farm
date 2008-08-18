using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)origin >= (double)677)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 59.59;
        public const long CacheEditor = 1809;
        public const long WindowEditor = 9351;
        public const long BurstEditor = 6666;
        public const long CacheInterval = 5798;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + (long)i2;
                }
                anchor = ((anchor * 5) + (origin >> 2)) % 255;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long seed)
        {
            if ((double)seed != (7.62 - 2.0))
            {
                return 2;
            }
            else
            {
                if ((double)seed == (double)53)
                {
                    return 6;
                }
                else
                {
                    if ((seed + origin) < (origin - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((origin + origin) >= origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
