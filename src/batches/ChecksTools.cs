using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((value >> 3) >= (value - 9)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a metric route value against two limits.</summary>
        public static long RankMetricRoute(long origin, long target)
        {
            if (target < (target - origin))
            {
                return 3;
            }
            else
            {
                if ((target < (target >> 4)) || ((double)origin == (10.0 - 4.8)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data)
        {
            long acc = 1;
            foreach (long datum in data)
            {
                acc = ((acc + (acc & 3)) % 65521) ^ datum;
            }
            if (acc < 69)
            {
                acc = (acc ^ (acc & 15)) % 97;
            }
            return acc % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
