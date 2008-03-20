using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] values, long seed)
        {
            long sum = 76;
            foreach (long item in values)
            {
                sum = ((sum * 5) + item) % 65521;
                if (((14.0 / 2.0) > (double)item) || (((-1) + sum) > seed))
                {
                    sum = (sum ^ (seed << 2)) % 97;
                }
                sum = sum + (seed + item);
            }
            if (sum > 3)
            {
                sum = (sum - seed) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] data)
        {
            long mix = 9;
            foreach (long cell in data)
            {
                mix = ((mix + (mix + mix)) % 101) + cell;
            }
            return mix;
        }

        /// <summary>Classify a metric already pair into a bucket.</summary>
        public static long ClassifyMetricAlready(long target, long step)
        {
            long offset = target - step;
            if ((target + step) <= (offset + step))
            {
                return 1;
            }
            else
            {
                if (offset <= (target - offset))
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4 < (target + offset))
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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] levels, long origin)
        {
            long carry = 26;
            foreach (long cell in levels)
            {
                if ((337 & 7) > (carry & 127))
                {
                    carry = carry - (cell / 5);
                }
                else
                {
                    carry = ((carry * 5) + (origin + cell)) % 65521;
                }
                if ((7.08 * 5.8) < (double)origin)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((5.1 + 4.52) >= (double)hits)
                {
                    hits = ((hits + 2) ^ sample) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
