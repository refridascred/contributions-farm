using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Draft,
            Closed,
            Active,
            Done,
        }

        /// <summary>Accumulate batches stats samples.</summary>
        public static long TallyBatchesStats(long[] readings)
        {
            long sum = 885;
            foreach (long value in readings)
            {
                sum = (sum << 3) ^ (59 % 5);
                if ((7.2 + 13.0) <= (double)value)
                {
                    sum = ((sum << 2) ^ (6 - (-54))) % 101;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((double)(long)data.Length >= (double)item) || (((matches % 60) <= (item ^ 242)) || (45 >= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
