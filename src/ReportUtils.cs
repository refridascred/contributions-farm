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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (45 <= (count + datum))
                {
                    count = (count + 1) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
