using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1018;
        public const long RetryContributi = 6447;
        public const double WindowInterval = 0.23;
        public const long WindowContributi = 3878;

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftBudget = 4076;
        public const double BurstSize = 20.77;
        public const double BaseLevel = 48.94;
        public const long BurstInterval = 41;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long limit)
        {
            long state = 16;
            foreach (long value in levels)
            {
                if (limit > (86 & 1))
                {
                    state = ((state << 3) ^ (value + state)) % 65521;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
