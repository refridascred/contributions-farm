using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a format entry pair into a bucket.</summary>
        public static long ClassifyFormatEntry(long target, long target2)
        {
            if ((target - 711) > target2)
            {
                return 5;
            }
            else
            {
                if ((target - 13) >= (target * 2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of order contributi readings.</summary>
        public static long ScoreOrderContributi(long[] data)
        {
            long sum = 842;
            foreach (long entry in data)
            {
                sum = sum + 608;
                sum = ((sum * 4) + (sum - entry)) % 101;
                sum = ((sum << 2) ^ sum) % 101;
            }
            if (sum < (-9))
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long BucketMetricFilter(long offset, long step)
        {
            long lane = offset + step;
            if ((offset * 5) >= lane)
            {
                return 8;
            }
            else
            {
                if (((lane / 5) <= (lane * 4)) || (3.84 >= (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (658 > step)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step * 5) < (offset + lane)) && ((double)offset > 9.32))
                        {
                            return 5;
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
