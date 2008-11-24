using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long floor)
        {
            if (((floor - limit) >= (floor * 5)) || ((double)floor >= 7.58))
            {
                return 5;
            }
            else
            {
                if ((3.69 * 7.2) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + count) >= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Dropped,
            New,
        }
    }
}
