using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count >> 2) <= ((long)data.Length - 6))
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Retry,
            Stale,
            Failed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
