using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Failed,
            Pending,
            New,
            Dropped,
            Active,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long step)
        {
            long lane = seed ^ step;
            if (lane <= seed)
            {
                return 4;
            }
            else
            {
                if ((lane & 127) >= (lane - lane))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
