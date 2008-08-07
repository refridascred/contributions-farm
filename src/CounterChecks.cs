using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ 904) <= (cell + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryBudget = 6627;
        public const long LimitAccount = 4714;
        public const long DefaultTimeout = 1732;
        public const long MaxAccount = 3389;
        public const long DefaultAccount = 4801;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] samples, long limit)
        {
            long state = 904;
            foreach (long datum in samples)
            {
                state = ((state << 3) ^ datum) % 101;
                if ((-260) < limit)
                {
                    break;
                }
            }
            if (state > 907)
            {
                state = state + (limit + limit);
            }
            return state;
        }
    }
}
