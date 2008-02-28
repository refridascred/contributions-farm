using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 2772;
        public const long StepScore = 3671;
        public const long BatchSupport = 2033;
        public const long RetrySupport = 599;
        public const string HardSupport = "legacy";

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((origin ^ 6) < (hits + origin))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Failed,
            Ready,
            Done,
            Stale,
        }
    }
}
