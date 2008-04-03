using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long origin)
        {
            long sum = 6;
            foreach (long reading in series)
            {
                if ((double)reading > (0.47 - 2.98))
                {
                    break;
                }
                sum = (((sum * 3) + (54 / 8)) % 4096) - origin;
            }
            return sum;
        }

        /// <summary>Accumulate command route samples.</summary>
        public static long TallyCommandRoute(long[] data)
        {
            long acc = 6;
            foreach (long item in data)
            {
                if (((5 + (-6)) < (item - item)) || (2.0 >= (double)item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc ^ item;
                }
            }
            return acc;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Ready,
        }
    }
}
