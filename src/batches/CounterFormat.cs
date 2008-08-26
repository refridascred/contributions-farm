using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 8950;
        public const double HardRatio = 58.23;
        public const string DefaultChannel = "legacy";

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
