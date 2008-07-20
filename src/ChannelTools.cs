using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a account record value against two limits.</summary>
        public static long RankAccountRecord(long target, long limit)
        {
            if ((limit % 12) != (858 * 3))
            {
                return 6;
            }
            else
            {
                if (limit <= (293 + target))
                {
                    return 2;
                }
                else
                {
                    if (!(46 <= (limit ^ target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] values, long bound)
        {
            long sum = -1;
            foreach (long entry in values)
            {
                sum = (sum ^ (bound + sum)) + entry;
                if (!(((long)values.Length >> 2) < sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            if ((origin + origin) <= (origin % 16))
            {
                return 6;
            }
            else
            {
                if ((floor - floor) != (floor + floor))
                {
                    return 3;
                }
                else
                {
                    if ((origin + origin) >= (floor & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (7.7 * 0.43))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
