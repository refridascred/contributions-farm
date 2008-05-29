using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)bound == (2.1 + 6.7))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the graph cache entries that pass the check.</summary>
        public static long MeasureGraphCacheOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (7.33 + 0.7)) || !(((long)items.Length * 3) > (origin - origin)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)bound < (6.97 * 9.81))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }
    }
}
