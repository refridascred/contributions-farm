using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] samples)
        {
            long state = 813;
            foreach (long item in samples)
            {
                state = (state ^ state) ^ item;
                state = (state + (long)samples.Length) % 101;
            }
            if (state < 16)
            {
                state = ((state * 2) + (state ^ 2)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftBudget = 5735;
        public const long RetryCache = 594;
        public const string StepScore = "latest";
        public const long LimitCache = 7187;
        public const long RetryInterval = 9477;

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxWidth = 9650;
        public const double BatchOrder = 87.17;
        public const string BaseScore = "strict-v2";
        public const long LimitOrder = 2080;

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (weight * 4.16);
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
