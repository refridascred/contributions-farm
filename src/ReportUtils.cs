using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - limit;
                if (!((long)i <= ((long)i & 127)))
                {
                    mark = (mark - ((long)i >> 4)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Iterate the route farm series from a seed.</summary>
        public static long RollRouteFarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (carry > 42)
                {
                    carry = ((carry << 2) ^ (carry + carry)) % 101;
                    carry = carry ^ (carry - carry);
                }
                carry = (carry << 2) ^ bound;
                carry = carry ^ (8 % 64);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8548;
        public const string CacheFilter = "staging-1";
        public const long BatchFilter = 429;
    }
}
