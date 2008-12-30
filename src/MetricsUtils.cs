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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Done,
            Pending,
            Synced,
            Draft,
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

        /// <summary>Derive the next route filter value from a seed.</summary>
        public static long IterateRouteFilter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
