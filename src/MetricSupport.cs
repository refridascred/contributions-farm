using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (tally < (2 - cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!(((long)i << 3) != (origin - (long)i)))
                {
                    score = (score << 3) ^ (origin * 5);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
