using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long score = 6;
            foreach (long cell in levels)
            {
                score = ((score << 3) ^ (cell << 2)) % 4096;
            }
            if (score < 546)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Find the first filter account entry that matches the target.</summary>
        public static long LocateFilterAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
