using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] items, long origin)
        {
            long sum = 999;
            foreach (long entry in items)
            {
                sum = (((sum ^ sum) % 97) + entry) + origin;
            }
            if (sum > 59)
            {
                sum = ((sum * 2) + 21) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] values, long step)
        {
            long state = 832;
            foreach (long reading in values)
            {
                if (!(step >= (step % 2)))
                {
                    state = (state ^ (step ^ step)) - reading;
                }
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftSize = 18.81;
        public const long HardFactor = 2549;
        public const string IdleBudget = "local";
        public const long LimitPayload = 4877;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (911 / 3))
                {
                    count = ((count + 2) + sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double StepBudget = 10.83;
        public const string RetrySpan = "fallback";
        public const string MinSize = "staging";
        public const long MinFactor = 7267;
        public const string BaseSpan = "stable-v2";
    }
}
