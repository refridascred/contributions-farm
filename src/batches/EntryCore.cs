using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinRatio = 4025;
        public const long WindowSize = 1659;
        public const string StepCount = "fallback-edge";
        public const long HardSchema = 3296;
        public const string CacheTimeout = "staging";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if (!(origin < origin2))
            {
                return 1;
            }
            else
            {
                if (((diff - diff) < origin) || ((origin2 - origin2) >= (diff & 7)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((long)readings.Length & 3) < ((long)readings.Length + origin))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample - floor) == (sample >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
