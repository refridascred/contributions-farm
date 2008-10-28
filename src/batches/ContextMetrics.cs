using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Ready,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Closed,
            Paused,
            Active,
            Pending,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long state = -4;
            foreach (long datum in items)
            {
                if ((double)datum <= (4.91 + 7.85))
                {
                    state = (state << 3) ^ datum;
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next schema context value from a seed.</summary>
        public static long SeriesSchemaContext(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (total & 63)) % 65521;
                total = (total ^ (total - total)) % 101;
                if (step > (step - step))
                {
                    total = (total ^ (total * 2)) % 1000;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
