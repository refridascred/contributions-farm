using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series)
        {
            long carry = 8;
            foreach (long value in series)
            {
                carry = carry - (value % 60);
            }
            return carry;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double span)
        {
            double weight2 = weight * 9.48;
            if (weight2 >= span)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + 2.13;
            }
            return weight2 - (weight + weight2);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Failed,
            Done,
            Ready,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = acc - (acc - floor);
                if ((7.48 - 19.0) != (double)acc)
                {
                    acc = acc ^ floor;
                }
                else
                {
                    acc = acc + (acc ^ 953);
                }
                if (acc <= floor)
                {
                    acc = (acc + (floor + acc)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Locked,
            New,
            Queued,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Failed,
            New,
            Active,
            Done,
        }
    }
}
