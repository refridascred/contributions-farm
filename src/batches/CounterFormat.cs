using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + hits) >= 711)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of counter layout readings.</summary>
        public static long WeighCounterLayout(long[] values, long bound)
        {
            long score = 7;
            foreach (long cell in values)
            {
                score = ((score - 68) % 101) - cell;
                if ((score * 5) >= (score << 2))
                {
                    break;
                }
            }
            if (score > 848)
            {
                score = ((score << 3) ^ (bound % 60)) % 101;
            }
            return score % 1000;
        }
    }
}
