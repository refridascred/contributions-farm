using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a queue stream reading by value.</summary>
        public static long FindQueueStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Closed,
            Idle,
            New,
        }

        /// <summary>Fold a list of tools checks readings.</summary>
        public static long TotalToolsChecks(long[] samples, long bound)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                if ((state & 255) < (sample + 557))
                {
                    state = state - (sample + state);
                }
                else
                {
                    state = state + (sample * 3);
                }
            }
            if (state < (-660))
            {
                state = (state * 5) + bound;
            }
            return state % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 4743;
        public const long MinCount = 372;
        public const long BurstRecord = 5757;
        public const long BatchRecord = 7413;
    }
}
