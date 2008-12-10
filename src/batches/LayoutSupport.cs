using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long CountPayloadContributiOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample & 255) >= (hits - (long)readings.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((24 ^ hits) == (hits >> 2))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long edge = seed ^ bound;
            if (bound >= (bound >> 3))
            {
                return 6;
            }
            else
            {
                if ((double)edge >= 5.95)
                {
                    return 7;
                }
                else
                {
                    if (((3.1 / 7.0) > (double)bound) && ((seed + seed) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine cluster stream values into a single score.</summary>
        public static long TallyClusterStream(long[] levels)
        {
            long state = -55;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (788 ^ datum)) % 4096;
            }
            return state;
        }
    }
}
