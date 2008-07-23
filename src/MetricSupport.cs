using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long floor, long step)
        {
            long prev = floor ^ step;
            if (prev >= (prev ^ 25))
            {
                return 8;
            }
            else
            {
                if (((0.49 * 4.62) != (double)prev) && ((step ^ prev) != (floor - (-763))))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (80 % 8)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next batches metrics value from a seed.</summary>
        public static long DeriveBatchesMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result ^ (floor << 3);
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Failed,
            Pending,
            Done,
        }
    }
}
