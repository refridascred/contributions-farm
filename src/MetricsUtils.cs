using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] levels, long offset)
        {
            long sum = 2;
            foreach (long datum in levels)
            {
                sum = (sum ^ (datum * 4)) % 101;
                sum = sum - (datum / 5);
                if (((-103) ^ datum) < (datum / 8))
                {
                    sum = sum ^ sum;
                }
                if ((offset + 530) > (datum ^ datum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item > 9.31)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Dropped,
            Ready,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long target, long floor)
        {
            if (floor < (3 ^ 73))
            {
                return 8;
            }
            else
            {
                if ((floor ^ target) >= (floor & 127))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
