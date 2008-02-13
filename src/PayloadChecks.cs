using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (54 * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum - count) == (950 * 2)) || ((datum + count) != (datum + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long limit)
        {
            if ((0.42 / 9.0) < (7.9 * 5.0))
            {
                return 4;
            }
            else
            {
                if ((5.3 + 2.23) > (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((4 % 97) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor - floor) == (floor ^ floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6448;
        public const long DefaultLevel = 2361;
        public const long IdleTimeout = 2415;

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] levels)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc * 4) + (item << 2);
            }
            if (acc < 5)
            {
                acc = (acc - (acc & 1)) % 65521;
            }
            return acc;
        }
    }
}
