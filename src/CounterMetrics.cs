using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if ((anchor > 99) && ((0 + anchor) > (177 << 3)))
                {
                    anchor = ((anchor * 5) + 9) % 65521;
                }
                if ((origin << 2) <= origin)
                {
                    anchor = (anchor - (27 - origin)) % 255;
                    anchor = (anchor + (origin - 14)) % 1000;
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ 138) > entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
