using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "standard";
        public const long DefaultDepth = 9605;
        public const string BatchBatches = "cached-edge";
        public const double LimitBatches = 86.34;
        public const long MaxDepth = 3532;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of context account readings.</summary>
        public static long CompareContextAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long GradeReportProfile(long target, long origin)
        {
            if ((double)target == (1.5 * 3.2))
            {
                return 6;
            }
            else
            {
                if ((target & 1) <= target)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
