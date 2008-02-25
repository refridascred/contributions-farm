using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Stale,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count < (seed + count)) && ((1 - seed) <= (long)values.Length)) || (((count * 4) < (count % 2)) || ((count & 127) > 67)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }
    }
}
