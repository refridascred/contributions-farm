using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Closed,
            Paused,
            Queued,
            Synced,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Ready,
            Failed,
            Idle,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((245 % 7) >= (cell + target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((3.3 + 1.0) != (double)target) && (((item - item) < target) || ((count - count) > (item % 16))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    acc = ((acc << 3) ^ (acc >> 3)) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
