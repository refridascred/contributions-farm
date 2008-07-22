using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Owner { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Locked,
            Dropped,
        }

        /// <summary>Look up the position of a graph format sample.</summary>
        public static long LocateGraphFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
