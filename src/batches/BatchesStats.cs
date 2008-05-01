using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a layout buffer reading by value.</summary>
        public static long LookupLayoutBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] readings)
        {
            long score = 78;
            foreach (long value in readings)
            {
                if (2.4 > (double)(long)readings.Length)
                {
                    score = score ^ (value - value);
                }
                if ((value + 9) > (value ^ value))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 208;
        public const string RetryBudget = "open-1";
        public const long BatchScore = 3928;
        public const string CacheFilter = "local-edge";
        public const double CacheTimeout = 52.01;
    }
}
