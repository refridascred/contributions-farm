using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the route stats entries that pass the check.</summary>
        public static long TallyRouteStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((53 ^ entry) == (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long floor)
        {
            long acc = 9;
            foreach (long entry in samples)
            {
                acc = acc + (entry ^ acc);
                acc = (acc ^ entry) % 255;
                if ((floor + floor) != (floor - entry))
                {
                    break;
                }
            }
            if (acc < 904)
            {
                acc = acc - (acc - acc);
            }
            return acc;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 54;
            foreach (long datum in levels)
            {
                total = ((total << 3) ^ ((long)levels.Length - total)) + datum;
            }
            if (total < 7)
            {
                total = (total << 2) ^ ((-79) % 97);
            }
            return total % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6702;
        public const long DefaultSpan = 6030;
        public const long SoftFormat = 4342;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
