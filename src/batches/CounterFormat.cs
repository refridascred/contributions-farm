using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long offset2)
        {
            if (((offset2 / 8) < (offset - offset)) || ((7.0 - 3.7) == (double)offset2))
            {
                return 4;
            }
            else
            {
                if ((24 ^ offset) > (99 - offset2))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
