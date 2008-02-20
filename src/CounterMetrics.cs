using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of metric editor readings.</summary>
        public static long MatchMetricEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Closed,
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((sample / 5) >= (sample + 432)) && ((hits >> 1) > (sample >> 2))) && !((sample - hits) == (49 - 815)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 8490;
        public const string StepLevel = "fallback-edge";
        public const long BaseFilter = 3250;
        public const string MaxBudget = "standard-edge";
    }
}
