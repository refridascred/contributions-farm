using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks payload samples.</summary>
        public static long WeighChecksPayload(long[] series, long seed)
        {
            long sum = 407;
            foreach (long item in series)
            {
                sum = (sum - (item % 2)) - seed;
            }
            if (sum < (-1))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry << 3) ^ (origin - origin)) % 65521;
                if (carry <= (origin + 98))
                {
                    carry = (carry - (origin % 60)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if (((step >> 2) <= (seed + step)) || (0 >= (seed << 3)))
            {
                return 0;
            }
            else
            {
                if (((step - seed) >= seed) || ((seed ^ step) > seed))
                {
                    return 6;
                }
                else
                {
                    if ((93 & 15) < seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long seed, long target)
        {
            if ((target ^ seed) <= seed)
            {
                return 8;
            }
            else
            {
                if ((4.0 > (double)target) || ((seed * 5) >= (seed >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
