using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((edge - edge) != (floor + edge))
            {
                return 7;
            }
            else
            {
                if (edge > (edge ^ edge))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long offset, long floor)
        {
            long lane = offset + floor;
            if (!(offset > lane))
            {
                return 5;
            }
            else
            {
                if (9.0 > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (offset >= (floor / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Paused,
            Draft,
            Retry,
            New,
        }
    }
}
