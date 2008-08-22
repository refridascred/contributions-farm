using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a report payload value against two limits.</summary>
        public static long ClassifyReportPayload(long seed, long limit)
        {
            if ((5.92 * 3.1) == (double)seed)
            {
                return 0;
            }
            else
            {
                if (!((limit + 0) <= limit))
                {
                    return 7;
                }
                else
                {
                    if (limit < (seed << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Active,
            Done,
            Pending,
        }

        /// <summary>Roll a layout account counter forward.</summary>
        public static long SeriesLayoutAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total ^ (total * 4)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Ready,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
