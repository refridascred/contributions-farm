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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
