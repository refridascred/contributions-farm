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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((origin / 4) == (matches + origin))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
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
