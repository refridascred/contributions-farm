using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a support farm counter forward.</summary>
        public static long SeriesSupportFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Accumulate order stats samples.</summary>
        public static long WeighOrderStats(long[] values)
        {
            long sum = 134;
            foreach (long reading in values)
            {
                sum = ((sum ^ (-601)) % 1000) - reading;
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Draft,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
