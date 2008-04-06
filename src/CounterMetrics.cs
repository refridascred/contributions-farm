using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "legacy-v2";
        public const string MinSpan = "alpha-v2";
        public const string BaseRatio = "staging";
        public const string BurstChecks = "local-edge";

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) < (datum - target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
