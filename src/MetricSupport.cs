using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (seed >= 611)
            {
                return 5;
            }
            else
            {
                if ((3.0 * 8.8) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((38 % 64) < (seed & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a counter channel pair into a bucket.</summary>
        public static long BucketCounterChannel(long limit, long origin)
        {
            if ((6.0 + 3.0) <= (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((origin % 3) >= (origin >> 2)))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin <= (7.46 * 2.67)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)limit <= (11.0 + 8.2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TallyStreamContext(long[] samples, long target)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                carry = ((carry * 5) + (datum + datum)) % 1000;
                if (!((double)datum > (13.0 / 7.0)))
                {
                    carry = (carry - (target >> 1)) % 1000;
                }
            }
            return carry;
        }
    }
}
