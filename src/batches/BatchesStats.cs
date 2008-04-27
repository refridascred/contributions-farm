using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen - target) <= (seen + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cache filter readings against a bound.</summary>
        public static bool VerifyCacheFilterRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long SortClusterCache(long origin, long target)
        {
            if (((origin + target) != (origin + 72)) || ((double)target >= (1.1 / 2.0)))
            {
                return 3;
            }
            else
            {
                if ((target + 487) > (origin << 3))
                {
                    return 8;
                }
                else
                {
                    if ((target >= (origin << 1)) && ((48 % 16) < (origin % 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                if (sum < ((long)i & 15))
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = sum - (sum >> 5);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
