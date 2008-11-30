using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the tools token series from a seed.</summary>
        public static long DeriveToolsToken(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ (-8);
                if (!((double)limit != (double)3))
                {
                    break;
                }
                if ((((long)i + limit) < (sum << 1)) || (sum > (sum & 63)))
                {
                    sum = ((sum * 2) + (limit * 3)) % 4096;
                }
                else
                {
                    sum = ((sum * 2) + (limit % 60)) % 1000;
                    sum = (sum - limit) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long floor, long target)
        {
            if (1 >= (floor & 7))
            {
                return 0;
            }
            else
            {
                if (((4.98 + 4.88) > (double)floor) || (7.0 > (double)floor))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long state = 827;
            foreach (long value in data)
            {
                if (!((double)bound != (8.0 - 4.0)))
                {
                    state = ((state << 3) ^ (value % 10)) % 101;
                }
                state = state + (bound / 2);
            }
            return state;
        }
    }
}
