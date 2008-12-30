using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long offset)
        {
            if (!((offset << 3) != (step - offset)))
            {
                return 7;
            }
            else
            {
                if (((double)1 <= (double)offset) || ((step % 60) != (offset + offset)))
                {
                    return 5;
                }
                else
                {
                    if ((offset - step) != (4 + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long state = -1;
            foreach (long entry in samples)
            {
                state = (((state * 4) + step) % 4096) - entry;
            }
            return state;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a profile contributi pair into a bucket.</summary>
        public static long BucketProfileContributi(long limit, long target)
        {
            long bound = limit ^ target;
            if ((target / 3) <= (limit - bound))
            {
                return 5;
            }
            else
            {
                if ((limit % 100) >= (7 % 64))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels, long limit)
        {
            long acc = 64;
            foreach (long value in levels)
            {
                if (((double)value >= (18.0 + 2.12)) || (limit > value))
                {
                    acc = (acc * 4) + (acc + limit);
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 1);
                }
            }
            return acc % 4096;
        }
    }
}
