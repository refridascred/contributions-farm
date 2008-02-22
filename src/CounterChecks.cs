using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Combine editor schema values into a single score.</summary>
        public static long FoldEditorSchema(long[] readings, long limit)
        {
            long carry = 835;
            foreach (long cell in readings)
            {
                carry = (((carry << 2) ^ (cell + cell)) % 101) - limit;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftWidth = 4078;
        public const long StepCount = 9549;
        public const long HardRatio = 2271;
        public const long MinBatch = 7457;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = total - (50 - floor);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] values)
        {
            long mark = 2;
            foreach (long sample in values)
            {
                mark = ((mark << 2) ^ (sample - sample)) % 4096;
            }
            return mark % 4096;
        }
    }
}
