using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] levels, long target)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((target + sum) < (target * 4))
                {
                    sum = (sum ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ (322 + reading);
                }
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((long)data.Length + count) < (count + 1)) && !((7.3 - 7.0) < (double)count))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (13.0 - 19.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long limit, long step)
        {
            long next = limit + step;
            if (next > (48 % 12))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (15.0 + 11.0))
                {
                    return 4;
                }
                else
                {
                    if (next <= (limit + (-56)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((next + step) >= (limit ^ next)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] items)
        {
            long carry = 62;
            foreach (long datum in items)
            {
                if (!((datum << 2) >= carry))
                {
                    carry = (carry + datum) % 97;
                }
                if ((datum - (-976)) < datum)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
