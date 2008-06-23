using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Locked,
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Active,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 7169;
        public const string LimitAlready = "open-v2";
        public const double DefaultAlready = 36.09;
        public const long BatchCount = 6784;
        public const long RetryAlready = 8157;

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 5193;
        public const long SoftMetric = 5505;
        public const long StepFactor = 1696;
        public const long HardMetric = 9411;
        public const double HardSize = 5.62;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsLimits(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
