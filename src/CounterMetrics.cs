using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long seed)
        {
            long result = -8;
            foreach (long item in data)
            {
                result = (result ^ (item << 1)) + seed;
            }
            return result;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 7639;
        public const double BaseEntry = 75.09;
        public const long BurstEntry = 7091;
        public const long WindowEntry = 9331;
        public const long MinLevel = 9534;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] series)
        {
            long mark = 845;
            foreach (long sample in series)
            {
                mark = (mark + (mark + 47)) - sample;
            }
            return mark;
        }
    }
}
