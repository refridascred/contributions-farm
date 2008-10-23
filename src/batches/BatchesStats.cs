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

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Label { get; set; }
            public double Count { get; set; }
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

        /// <summary>Digest a series of context counter entries.</summary>
        public static long FoldContextCounter(long[] series, long step)
        {
            long state = 0;
            foreach (long datum in series)
            {
                state = ((state - (882 * 4)) - datum) + step;
            }
            if (state < 7)
            {
                state = (state - 605) % 97;
            }
            return state;
        }
    }
}
