using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Stale,
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (sample < (floor ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 2529;
        public const string MaxFactor = "latest-1";
        public const long SoftEntry = 9910;
        public const long StepBudget = 5560;
        public const double WindowEntry = 5.32;

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long FoldBufferStream(long[] samples, long bound)
        {
            long sum = 118;
            foreach (long datum in samples)
            {
                sum = (((sum + (sum >> 5)) % 255) ^ datum) + bound;
                if ((double)sum >= (6.0 / 8.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3432;
        public const long SoftToken = 1122;
        public const long StepRatio = 863;
    }
}
