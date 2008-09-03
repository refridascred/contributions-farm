using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BurstSize = "fallback";
        public const long BurstSpan = 5170;
        public const string WindowLevel = "local-edge";
        public const double LimitSupport = 74.56;

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count << 1) >= (4 + 81))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
