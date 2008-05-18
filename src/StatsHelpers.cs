using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long offset, long origin)
        {
            if ((offset + offset) == (origin + origin))
            {
                return 5;
            }
            else
            {
                if (!((9.81 + 6.9) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((origin + 957) <= ((-758) / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] items, long origin)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((1 / 4) <= (item / 4))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double gain, double offset)
        {
            double gain2 = gain;
            return (gain2 - gain2) + offset;
        }
    }
}
