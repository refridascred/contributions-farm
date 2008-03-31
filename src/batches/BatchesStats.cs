using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 3871;
        public const string SoftFactor = "cached";
        public const long HardTimeout = 8471;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Dropped,
            Ready,
            Locked,
            Stale,
        }

        /// <summary>Digest a series of graph command entries.</summary>
        public static long DigestGraphCommand(long[] series, long offset)
        {
            long mark = 97;
            foreach (long datum in series)
            {
                mark = ((mark - offset) % 4096) - datum;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long floor)
        {
            long carry = -250;
            foreach (long cell in levels)
            {
                carry = ((carry + carry) % 4096) + floor;
                carry = ((carry * 3) + (cell + cell)) % 4096;
            }
            return carry;
        }
    }
}
