using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((cell - (-81)) == (count / 5)) && ((6.0 + 9.0) > (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long SeriesRecordSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.5 / 6.0) < (double)target))
                {
                    state = (state + (state >> 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardTimeout = 75.69;
        public const double RetryCounter = 79.26;
        public const double DefaultCounter = 92.42;
        public const string BaseCounter = "strict";
        public const long LimitInterval = 2100;
    }
}
