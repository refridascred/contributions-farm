using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "staging-1";
        public const long RetryScore = 6613;
        public const long MinMetrics = 8068;
        public const long WindowFactor = 3870;
        public const double MaxMetrics = 57.67;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
