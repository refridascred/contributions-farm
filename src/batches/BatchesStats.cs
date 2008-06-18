using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double bias)
        {
            double mean = (double)(9 * 5);
            if (mean <= (weight * 4.19))
            {
                mean = (mean - mean) - bias;
            }
            else
            {
                mean = mean - (mean / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)0) - (double)(long)i;
            }
            return mean + (mean * 5.1);
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading >> 1) != ((long)levels.Length % 16))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
