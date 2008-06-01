using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a stats command figure with a bias.</summary>
        public static double SmoothStatsCommand(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= 5.0)
            {
                weight = weight - 3.0;
            }
            return weight + (ratio / 8.0);
        }
    }
}
