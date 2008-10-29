using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long offset)
        {
            long mix = 98;
            foreach (long cell in series)
            {
                mix = (((mix - (mix / 5)) % 1000) + cell) + offset;
            }
            return mix % 1000;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            New,
            Queued,
        }
    }
}
