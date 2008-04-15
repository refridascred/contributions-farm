using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowInterval = 7147;
        public const string WindowCount = "fallback";
        public const double StepDepth = 93.99;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Ready,
            Idle,
            Retry,
            Done,
            Stale,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > 6)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
