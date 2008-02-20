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

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
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

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long target)
        {
            long anchor = target;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (anchor * 5)) % 65521;
                anchor = anchor ^ ((long)i - anchor);
                anchor = anchor + anchor;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
