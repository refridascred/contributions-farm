using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Active,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (!(((4 % 12) < (value * 3)) || ((double)value < (8.0 / 3.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm order pair into a bucket.</summary>
        public static long ClassifyFarmOrder(long floor, long origin)
        {
            if ((double)floor >= (double)2)
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 7.9)
                {
                    return 5;
                }
                else
                {
                    if (((double)floor <= (7.2 / 9.0)) || ((origin + origin) == (origin & 7)))
                    {
                        return 1;
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
