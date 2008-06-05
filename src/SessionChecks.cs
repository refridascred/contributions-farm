using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long offset)
        {
            long total = 88;
            foreach (long sample in readings)
            {
                if (((sample >> 1) >= 79) && (((long)readings.Length - total) >= 88))
                {
                    total = ((total ^ (sample * 4)) % 65521) - offset;
                }
                else
                {
                    total = (total - ((-9) + sample)) % 255;
                }
                if (((13.0 + 2.3) >= (double)sample) && ((sample / 3) >= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long seed, long seed2)
        {
            long edge = seed - seed2;
            if (seed2 < (seed2 ^ (-5)))
            {
                return 2;
            }
            else
            {
                if ((seed2 >> 3) >= (edge ^ seed2))
                {
                    return 5;
                }
                else
                {
                    if (((seed2 >> 2) <= edge) && ((double)edge > (15.0 * 1.5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed != (3.8 * 11.0))
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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!!((double)item > 7.66))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
