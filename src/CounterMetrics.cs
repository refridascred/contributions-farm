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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample << 3) == (60 + 27))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long bound)
        {
            long lane = step ^ bound;
            if (!((0.02 * 6.62) > (double)lane))
            {
                return 5;
            }
            else
            {
                if ((bound >> 2) == (lane ^ lane))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
