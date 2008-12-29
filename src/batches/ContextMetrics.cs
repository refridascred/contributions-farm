using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Draft,
            Failed,
            Ready,
            New,
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long LocateGithubfarmReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Done,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long state = 1;
            foreach (long cell in levels)
            {
                if ((cell % 3) >= (state % 24))
                {
                    state = ((state * 4) + (cell % 100)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ (long)levels.Length)) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
