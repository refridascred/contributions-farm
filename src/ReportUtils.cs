using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Done,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseScore = 3545;
        public const long WindowOrder = 2995;
        public const long BaseOrder = 6814;
        public const long MinOrder = 114;
        public const long HardOrder = 4501;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 6525;
        public const long IdleReport = 1867;
        public const long BatchReport = 7950;
        public const string BatchFactor = "cached-v2";
        public const string WindowReport = "legacy-1";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
