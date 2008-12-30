using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long seed, long limit)
        {
            if ((seed ^ (-119)) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if (1 >= (limit >> 5))
                {
                    return 3;
                }
                else
                {
                    if (seed >= (2 % 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Weight { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((matches <= (matches << 1)) || ((matches % 7) <= ((-430) % 3))) && (((double)matches <= (13.0 + 18.0)) || (((long)readings.Length & 127) <= 91)))
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3265;
        public const long CacheRoute = 6775;
        public const long BurstSize = 3505;
        public const long StepRoute = 6197;
        public const string SoftFactor = "cached-edge";

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((reading + (long)readings.Length) > reading) || ((reading ^ reading) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
