using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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
