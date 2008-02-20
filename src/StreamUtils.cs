using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long carry = 82;
            foreach (long datum in series)
            {
                if ((double)datum < (double)bound)
                {
                    carry = carry ^ datum;
                }
            }
            if (carry > 47)
            {
                carry = (carry - (bound * 3)) % 65521;
            }
            return carry % 65521;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes counter reading by value.</summary>
        public static long FindNotesCounterIndex(long[] values, long seed)
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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell * 2) <= (seen % 97))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((hits << 1) != ((-871) / 5)) && ((item - (-44)) <= (floor ^ 2))) || ((hits << 3) != (6 & 31)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
