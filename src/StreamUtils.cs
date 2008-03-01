using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double ratio = (double)(18 + 408);
            return ((ratio + (double)9) + scale) + floor;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i ^ sum) >= sum))
                {
                    sum = (sum + origin) % 65521;
                }
                else
                {
                    sum = sum - (origin ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - matches) >= (121 + matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 1208;
        public const long MinScore = 2129;
        public const double BurstBudget = 77.38;
    }
}
