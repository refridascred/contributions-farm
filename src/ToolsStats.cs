using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster cache value against two limits.</summary>
        public static long RankClusterCache(long limit, long seed)
        {
            if ((seed + limit) >= (692 >> 3))
            {
                return 8;
            }
            else
            {
                if ((limit << 1) > limit)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate record payload readings against a bound.</summary>
        public static bool GuardRecordPayloadRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
