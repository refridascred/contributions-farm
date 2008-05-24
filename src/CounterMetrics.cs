using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 1351;
        public const double StepCount = 54.31;
        public const long RetrySchema = 4687;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally >= (item + item)) && !(((long)series.Length + item) > (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items, long bound)
        {
            long mix = 27;
            foreach (long item in items)
            {
                mix = ((mix ^ (bound ^ bound)) % 101) ^ item;
            }
            return mix;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Closed,
            Active,
        }
    }
}
