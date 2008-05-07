using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a batches route pair into a bucket.</summary>
        public static long SortBatchesRoute(long offset, long limit)
        {
            long cur = offset - limit;
            if (((limit ^ limit) < (limit + limit)) && (8.95 > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((cur << 2) < (offset + 5))
                {
                    return 4;
                }
                else
                {
                    if (!((175 >> 2) < (cur - limit)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            New,
            Active,
            Synced,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = result + (entry << 3);
            }
            if (result > 31)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result % 65521;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((18 - 79) > (775 - value))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + (step - step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
