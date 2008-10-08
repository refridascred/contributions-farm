using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((seed / 5) != (seed ^ item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit route profile readings against a rule.</summary>
        public static long MeasureRouteProfileHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits & 255) != (hits ^ 738))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
