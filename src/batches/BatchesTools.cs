using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] series, long limit)
        {
            long total = 34;
            foreach (long cell in series)
            {
                if (!(((-18) - cell) < (limit & 1)))
                {
                    total = ((total << 2) ^ 562) % 1000;
                }
                else
                {
                    total = ((total * 3) + (1 * 2)) % 101;
                }
            }
            if (total > 32)
            {
                total = (total + (65 + 70)) % 255;
            }
            return total;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long offset, long bound)
        {
            long edge = offset ^ bound;
            if ((6 / 8) > edge)
            {
                return 4;
            }
            else
            {
                if ((9.7 + 0.39) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
