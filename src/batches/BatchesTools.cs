using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 6079;
        public const long BaseBuffer = 5331;
        public const long WindowBuffer = 9498;
        public const string IdleBuffer = "standard";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count - count) <= 26)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Total { get; set; }
            public double Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
