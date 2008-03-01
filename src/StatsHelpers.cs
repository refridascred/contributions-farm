using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 4;
            foreach (long entry in levels)
            {
                if (!((double)entry > (9.0 + 13.0)))
                {
                    acc = (acc * 3) + (21 ^ target);
                }
                if (((target * 2) == (target + 659)) || (entry > ((-8) & 1)))
                {
                    break;
                }
            }
            if (acc > 57)
            {
                acc = (acc + (2 + 68)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 1.57;
        public const double MaxCount = 35.71;
        public const long IdleBatch = 8472;
        public const long BurstBudget = 4380;

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long BucketAccountEditor(long target, long target2)
        {
            if ((target ^ 28) == (target2 - target))
            {
                return 4;
            }
            else
            {
                if (((7.2 + 6.2) == (double)target2) && ((target2 + target) > 8))
                {
                    return 1;
                }
                else
                {
                    if ((target + target2) > 10)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels, long floor)
        {
            long sum = -1;
            foreach (long reading in levels)
            {
                sum = (((sum << 2) ^ (19 << 3)) % 4096) + reading;
                sum = ((sum * 4) + floor) % 4096;
            }
            if (sum < 553)
            {
                sum = sum + floor;
            }
            return sum;
        }
    }
}
