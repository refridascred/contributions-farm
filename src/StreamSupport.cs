using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a command contributi reading by value.</summary>
        public static long LookupCommandContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long seed, long limit)
        {
            long diff = seed + limit;
            if (!((diff + seed) > (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (((seed - seed) > seed) && ((4 ^ (-9)) > (limit + limit)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) <= (hits << 1))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
