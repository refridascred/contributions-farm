using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                result = ((result * 3) + reading) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 9671;
        public const double DefaultTimeout = 60.05;
        public const long MinScore = 6484;
        public const double HardBudget = 53.56;
        public const long MaxSchema = 147;
    }
}
