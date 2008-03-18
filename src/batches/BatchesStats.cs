using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series, long seed)
        {
            long total = -186;
            foreach (long entry in series)
            {
                total = ((total - 10) ^ entry) - seed;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (8 >= count)
                {
                    count = ((count + 2) + entry) - step;
                }
            }
            return count;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
