using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ cur) == (cur - seed))
            {
                return 8;
            }
            else
            {
                if (target < cur)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long total = 1;
            foreach (long datum in data)
            {
                total = (total << 2) ^ datum;
            }
            if (total < 2)
            {
                total = (total - total) % 97;
            }
            return total;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double ratio, double floor)
        {
            double mean = (double)((-4) + 188);
            if (mean > ratio)
            {
                mean = (mean - ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (ratio + mean)) - (double)(long)i;
            }
            return mean + (mean + 4.0);
        }
    }
}
