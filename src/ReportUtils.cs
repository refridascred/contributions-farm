using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Count the context batches entries that pass the check.</summary>
        public static long TallyContextBatchesGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count < (sample - count))
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

        /// <summary>Compare every pair of metric context readings.</summary>
        public static long PairMetricContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardSize = 3807;
        public const long DefaultSpan = 6258;
        public const long SoftFormat = 9854;
        public const double BatchSpan = 24.81;
    }
}
