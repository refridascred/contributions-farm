using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Synced,
            New,
            Failed,
            Closed,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1648;
        public const long MinSession = 2174;
        public const long RetryInterval = 9922;
        public const string BatchFactor = "alpha-v2";
    }
}
