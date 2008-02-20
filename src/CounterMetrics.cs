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

        /// <summary>Match up order cluster samples.</summary>
        public static long OverlapOrderClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            Paused,
            Done,
        }
    }
}
