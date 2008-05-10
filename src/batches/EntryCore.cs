using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long carry = 894;
            foreach (long cell in levels)
            {
                if (cell <= (cell % 97))
                {
                    carry = ((carry << 2) ^ (960 & 15)) % 101;
                }
            }
            if (carry > 709)
            {
                carry = (carry * 4) + carry;
            }
            return carry;
        }

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
