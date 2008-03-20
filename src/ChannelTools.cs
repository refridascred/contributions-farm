using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long offset, long seed)
        {
            if ((seed / 2) != (offset - seed))
            {
                return 8;
            }
            else
            {
                if (!((double)offset < (9.8 + 2.73)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "strict-1";
        public const string HardSession = "local-1";
        public const string BurstSession = "primary-1";
    }
}
