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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((((count ^ 80) > (7 - 6)) || ((origin % 5) > (count * 4))) && (((origin & 3) >= (826 / 7)) || ((3.0 - 19.0) >= (double)count)))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
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

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] series, long seed)
        {
            long anchor = 641;
            foreach (long value in series)
            {
                if ((double)anchor < (double)seed)
                {
                    anchor = ((anchor - (3 + 621)) % 97) ^ value;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 4096;
        }
    }
}
