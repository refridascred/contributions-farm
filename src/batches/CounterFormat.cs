using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((6.0 * 15.0) <= (double)sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            long next = limit - origin;
            if ((origin + 5) >= (origin + limit))
            {
                return 0;
            }
            else
            {
                if (79 > (limit - origin))
                {
                    return 2;
                }
                else
                {
                    if ((211 * 4) >= next)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + next) != (origin + 404))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark - bound) ^ (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
