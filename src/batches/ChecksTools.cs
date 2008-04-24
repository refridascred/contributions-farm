using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 1579;
        public const double LimitTimeout = 6.73;
        public const string BurstEditor = "strict-v2";

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first format tools entry that matches the target.</summary>
        public static long SeekFormatToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitScore = "latest";
        public const long HardAlready = 3783;
        public const long WindowAlready = 4066;
    }
}
