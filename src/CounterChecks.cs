using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MinScore = 14;
        public const double StepProfile = 56.12;
        public const string HardTimeout = "open-v2";
        public const long BatchScore = 7715;
        public const long BaseProfile = 1414;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Ready,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long bound)
        {
            long total = -185;
            foreach (long cell in data)
            {
                total = (((total * 5) + (total >> 3)) + cell) + bound;
            }
            if (total > 66)
            {
                total = ((total * 4) + (total % 2)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Count the record schema entries that pass the check.</summary>
        public static long AuditRecordSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches + entry) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
