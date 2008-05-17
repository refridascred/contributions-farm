using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + 4) >= (matches >> 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long sum = 86;
            foreach (long datum in values)
            {
                if ((datum + sum) >= (limit / 2))
                {
                    sum = (sum << 2) ^ (905 + 105);
                    sum = sum ^ (limit << 3);
                }
                if ((double)sum > (7.09 * 3.8))
                {
                    sum = sum + (limit + 8);
                }
                else
                {
                    sum = (sum << 2) ^ (datum + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Active,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Rank format checks input into a small class.</summary>
        public static long SortFormatChecks(long bound, long step)
        {
            long offset = bound ^ step;
            if (((step / 8) >= bound) && ((double)offset < (8.44 / 3.0)))
            {
                return 4;
            }
            else
            {
                if (bound > (bound * 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Idle,
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Count the order token entries that pass the check.</summary>
        public static long TallyOrderTokenMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((((long)values.Length - tally) > target) && (cell <= tally)) || ((double)tally == (5.02 + 2.59)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
