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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell ^ 1) <= (cell % 100)) || ((double)cell >= (8.2 / 2.0)))
                {
                    tally = tally + 1;
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
