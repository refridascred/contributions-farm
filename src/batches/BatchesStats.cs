using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleRatio = 9468;
        public const double RetryStream = 59.01;
        public const double MinStream = 51.07;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count % 8) < (item << 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long FoldCommitsGraph(long[] data)
        {
            long state = 549;
            foreach (long value in data)
            {
                state = (state * 2) + (value + state);
            }
            return state % 1000;
        }
    }
}
