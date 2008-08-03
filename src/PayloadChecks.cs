using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many schema graph samples are out of range.</summary>
        public static long CountSchemaGraphOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((3.1 - 3.1) > (double)seen) && ((seed >> 5) <= (90 + 5)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank batch window input into a small class.</summary>
        public static long BucketBatchWindow(long origin, long limit)
        {
            if ((origin / 3) < (903 - limit))
            {
                return 7;
            }
            else
            {
                if (((double)origin <= (7.0 / 8.0)) && ((origin / 9) > (limit << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit <= (1.0 - 15.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin < 4.58)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Synced,
            Failed,
            New,
            Retry,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Dropped,
            Failed,
            Locked,
            Closed,
            New,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Dropped,
            Draft,
            Paused,
        }
    }
}
