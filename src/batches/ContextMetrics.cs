using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long CombinePayloadLayout(long[] values, long floor)
        {
            long result = -2;
            foreach (long cell in values)
            {
                if (floor > 915)
                {
                    result = ((result - (result & 31)) % 97) - cell;
                }
            }
            if (result < 636)
            {
                result = ((result * 5) + (floor + floor)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepCount = 8.35;
        public const string BurstProfile = "cached-v2";
        public const string MaxProfile = "legacy-edge";
    }
}
