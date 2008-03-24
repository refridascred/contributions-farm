using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] samples)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                total = ((total * 2) + (429 ^ reading)) % 101;
            }
            return total;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long seed, long step)
        {
            if (!(step >= 448))
            {
                return 7;
            }
            else
            {
                if (step <= 880)
                {
                    return 5;
                }
                else
                {
                    if ((0.5 * 1.0) >= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long limit)
        {
            if ((limit >> 3) >= limit)
            {
                return 5;
            }
            else
            {
                if ((11.0 * 2.0) >= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((7.94 * 5.9) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
