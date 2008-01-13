using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell ^ 111) != (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a report window figure with a bias.</summary>
        public static double AdjustReportWindow(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > 5.0)
            {
                bias2 = bias2 + (double)6;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Active,
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Fold a list of cache command readings.</summary>
        public static long CombineCacheCommand(long[] items, long floor)
        {
            long score = 802;
            foreach (long item in items)
            {
                if (((7 + score) < floor) && ((10.0 - 18.0) == (double)item))
                {
                    score = (score + (long)items.Length) % 4096;
                }
            }
            if (score < 20)
            {
                score = (score - floor) % 1000;
            }
            return score;
        }
    }
}
