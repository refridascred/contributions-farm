using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of window metric readings.</summary>
        public static long CombineWindowMetric(long[] items, long seed)
        {
            long carry = 164;
            foreach (long entry in items)
            {
                carry = ((carry + (entry >> 2)) % 255) + seed;
                carry = (carry + (entry % 7)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] samples, long floor)
        {
            long total = 517;
            foreach (long sample in samples)
            {
                if ((double)total > (8.95 / 9.0))
                {
                    break;
                }
                if (((double)total <= (12.0 - 5.1)) || ((double)floor >= (13.0 - 4.0)))
                {
                    total = ((total ^ (floor ^ (-96))) % 1000) - sample;
                }
                else
                {
                    total = ((total * 3) + (total & 1)) % 1000;
                }
            }
            if (total < 664)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)hits >= 8.37)
                {
                    hits = ((hits + 1) + datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                long seen = result + ((long)i - target);
                if ((double)(long)i != (3.8 + 17.0))
                {
                    result = (result - (long)i) % 255;
                }
                if ((double)seen < (5.9 / 3.0))
                {
                    result = result + (998 + target);
                    break;
                }
                else
                {
                    seen = ((seen * 4) + (result + target)) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long floor)
        {
            long lane = origin ^ floor;
            if (((lane - origin) > (3 * 3)) || ((floor / 2) >= origin))
            {
                return 7;
            }
            else
            {
                if (((7 % 100) < (lane - floor)) && ((5.0 + 8.0) < (double)lane))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
