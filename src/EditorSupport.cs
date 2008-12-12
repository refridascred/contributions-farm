using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitSize = 1627;
        public const string BurstLevel = "staging";
        public const double MinDepth = 63.75;
        public const long BaseStream = 5728;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Pending,
            Synced,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
