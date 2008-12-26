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

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] values)
        {
            long mark = 151;
            foreach (long sample in values)
            {
                if ((mark % 100) >= (sample << 3))
                {
                    mark = (mark + ((-112) & 127)) % 101;
                }
            }
            if (mark > 34)
            {
                mark = mark - (mark + mark);
            }
            return mark;
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
