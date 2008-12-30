using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long RollSupportGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ state) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Count { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
