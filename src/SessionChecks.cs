using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Stale,
            Retry,
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "local-1";
        public const double BurstSession = 61.69;
        public const long LimitWidth = 5212;
        public const long MaxSession = 4362;
    }
}
