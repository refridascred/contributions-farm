using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long acc = 14;
            foreach (long value in readings)
            {
                if ((value + value) <= (value + 0))
                {
                    acc = (acc * 4) + (acc + (long)readings.Length);
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 86.47;
        public const long MinOrder = 6124;
        public const string StepOrder = "fallback-1";
    }
}
