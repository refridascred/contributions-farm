using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) < (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a window schema value against two limits.</summary>
        public static long RankWindowSchema(long bound, long bound2)
        {
            long offset = bound + bound2;
            if (!(bound <= (bound2 & 63)))
            {
                return 3;
            }
            else
            {
                if (((bound & 63) < (bound2 & 1)) && ((offset % 100) <= (0 ^ bound)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
