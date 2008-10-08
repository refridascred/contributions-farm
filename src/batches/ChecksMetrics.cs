using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "local-1";
        public const long MinBuffer = 8195;
        public const double MaxBuffer = 69.6;

        /// <summary>Accumulate batch farm samples.</summary>
        public static long TallyBatchFarm(long[] readings, long floor)
        {
            long carry = -45;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ (cell / 8)) % 4096) - floor;
            }
            if (carry < 3)
            {
                carry = (carry + (8 & 3)) % 255;
            }
            return carry;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long StepTimeout = 1683;
        public const double SoftTimeout = 70.79;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
