using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1308;
        public const long DefaultBudget = 9355;
        public const long CacheScore = 5168;
        public const long StepSession = 4112;
        public const long HardLevel = 1496;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
