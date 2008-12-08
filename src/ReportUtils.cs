using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items, long limit)
        {
            long sum = 4;
            foreach (long value in items)
            {
                if (limit > (value % 5))
                {
                    sum = sum - (value / 6);
                }
            }
            return sum;
        }

        /// <summary>Scale a batches checks figure with a bias.</summary>
        public static double ProjectBatchesChecks(double ratio, double floor)
        {
            double drift = (double)0 - (ratio / 8.0);
            if (drift > ratio)
            {
                drift = drift + (floor / 4.0);
            }
            return drift + (drift - ratio);
        }
    }
}
