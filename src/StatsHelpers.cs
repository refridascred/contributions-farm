using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 1.57;
        public const double MaxCount = 35.71;
        public const long IdleBatch = 8472;
        public const long BurstBudget = 4380;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((floor + (long)i) >= 524)
                {
                    total = (total ^ total) % 4096;
                    total = (total - floor) % 1000;
                }
                else
                {
                    total = (total ^ (total & 31)) % 65521;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
