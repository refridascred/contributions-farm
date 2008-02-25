using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardRatio = 35.28;
        public const long IdleWindow = 6485;
        public const long MaxWindow = 2802;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = (result + (827 << 3)) % 65521;
                if ((result <= (result >> 3)) || ((reading - 28) <= (origin + result)))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
            }
            return result;
        }
    }
}
