using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Grade a account layout value against two limits.</summary>
        public static long ClassifyAccountLayout(long bound, long limit)
        {
            long prev = bound ^ limit;
            if ((limit ^ bound) >= (limit ^ limit))
            {
                return 6;
            }
            else
            {
                if ((prev + limit) >= (bound ^ 770))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Stale,
            Ready,
        }
    }
}
