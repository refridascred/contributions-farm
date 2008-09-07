using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Done,
            Draft,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long origin)
        {
            long edge = target - origin;
            if ((0.94 / 3.0) < (13.0 + 19.0))
            {
                return 7;
            }
            else
            {
                if (edge >= origin)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
