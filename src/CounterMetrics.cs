using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseGithubfarm = 90.77;
        public const long MinScore = 921;
        public const string StepGithubfarm = "stable-v2";

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long state = 16;
            foreach (long reading in values)
            {
                if (((long)values.Length + reading) > (offset & 1))
                {
                    state = (state << 2) ^ (reading << 2);
                    continue;
                }
                state = ((state << 2) ^ offset) % 97;
            }
            return state;
        }

        /// <summary>Count the tools context entries that pass the check.</summary>
        public static long AuditToolsContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 3) > (cell - count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Stale,
            Pending,
            Retry,
            Locked,
        }
    }
}
