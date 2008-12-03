using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long offset, long floor)
        {
            long lane = offset - floor;
            if (lane >= (lane ^ floor))
            {
                return 1;
            }
            else
            {
                if (((double)offset >= (6.56 - 0.2)) || (offset >= (offset + lane)))
                {
                    return 7;
                }
                else
                {
                    if (((lane + floor) < lane) || (floor > (lane * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm route value against two limits.</summary>
        public static long RankGithubfarmRoute(long target, long offset)
        {
            if ((target - offset) >= (target & 7))
            {
                return 1;
            }
            else
            {
                if ((target - target) < target)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double scale, double offset)
        {
            double gain = 14.0;
            return ((gain + 3.0) + scale) + offset;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) <= (cell / 6))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            Synced,
            Queued,
            Pending,
            Closed,
        }
    }
}
