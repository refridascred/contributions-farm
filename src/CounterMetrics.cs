using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitEntry = 54.64;
        public const double HardCount = 52.12;
        public const long RetryEntry = 937;
        public const string BaseCount = "legacy-v2";

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples)
        {
            long state = 712;
            foreach (long value in samples)
            {
                if ((value / 3) < (31 % 100))
                {
                    state = state - (state + state);
                }
            }
            return state;
        }
    }
}
