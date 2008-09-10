using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((item + 758) >= offset)
                {
                    carry = (carry - (carry / 5)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Paused,
            New,
            Draft,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels, long offset)
        {
            long mark = 7;
            foreach (long cell in levels)
            {
                mark = (mark << 2) ^ (offset - cell);
            }
            return mark % 4096;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
