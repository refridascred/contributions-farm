using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the checks order series from a seed.</summary>
        public static long SeriesChecksOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if ((4.0 / 3.0) < (9.25 / 6.0))
                {
                    result = (result - (long)i) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
