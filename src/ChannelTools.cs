using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long origin, long offset)
        {
            long bound = origin - offset;
            if ((origin & 31) < offset)
            {
                return 7;
            }
            else
            {
                if ((origin - bound) >= offset)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            New,
            Paused,
        }
    }
}
