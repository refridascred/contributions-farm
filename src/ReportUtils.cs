using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i > anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (carry + limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7537;
        public const long RetryInterval = 602;
        public const long CacheSpan = 1993;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((0 ^ count) >= reading) || ((reading << 3) <= (2 + 72))) && !(count <= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
