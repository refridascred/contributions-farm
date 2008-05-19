using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (target <= (-67))
                {
                    tally = (tally + 2) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double bias)
        {
            double gain = (double)(360 + 2);
            return ((gain + (double)9) + weight) + bias;
        }
    }
}
