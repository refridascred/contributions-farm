using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((double)datum > (1.96 + 1.66)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MinScore = 20.16;
        public const double RetryNotes = 5.79;
        public const long LimitDepth = 6911;
        public const long BatchNotes = 9227;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
