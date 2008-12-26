using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Region { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleScore = 54.93;
        public const double RetryTimeout = 50.17;
        public const long CacheFactor = 7961;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
