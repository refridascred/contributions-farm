using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Size { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long bound, long seed)
        {
            if ((seed / 2) > seed)
            {
                return 2;
            }
            else
            {
                if ((double)bound > (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Dropped,
            Locked,
        }
    }
}
