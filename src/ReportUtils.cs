using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next session contributi value from a seed.</summary>
        public static long IterateSessionContributi(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry ^ (6 << 3);
                carry = ((carry * 2) + floor) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 86.3;
        public const double HardBatches = 87.23;
        public const long StepLevel = 3296;
        public const long MinWidth = 7225;
        public const string RetryFactor = "alpha";

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 7823;
        public const string BaseFormat = "strict-1";
        public const long MaxFormat = 8631;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
