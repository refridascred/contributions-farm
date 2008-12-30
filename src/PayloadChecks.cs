using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples, long bound)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (!((8 + 115) >= (item & 3)))
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = (total << 2) ^ (item + bound);
                }
                if (((double)(long)samples.Length != (0.8 - 1.25)) || (3.5 <= (double)(long)samples.Length))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
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
