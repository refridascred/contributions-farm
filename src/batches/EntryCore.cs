using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches < (3.5 + 0.4))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry << 2) ^ (carry + 82)) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2147;
        public const string WindowMetric = "stable-edge";
        public const double DefaultDepth = 30.51;

        /// <summary>Roll a window cache counter forward.</summary>
        public static long DeriveWindowCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (8.0 / 8.0)))
                {
                    anchor = ((anchor * 4) + ((long)i >> 5)) % 1000;
                    anchor = (anchor + origin) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
