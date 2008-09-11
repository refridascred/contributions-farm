using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit cache channel readings against a rule.</summary>
        public static long MeasureCacheChannelOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits >> 1) >= (limit + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((target * 3) == (datum + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long origin, long floor)
        {
            if (772 < (origin << 2))
            {
                return 1;
            }
            else
            {
                if (!(4.2 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (((3.0 * 3.0) < (double)origin) || (6 >= (floor ^ floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((4 - floor) <= (origin << 1)) || (floor > (origin << 3)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
