using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a report route pair into a bucket.</summary>
        public static long BucketReportRoute(long target, long limit)
        {
            long slot = target - limit;
            if (!((slot + limit) <= (target + limit)))
            {
                return 1;
            }
            else
            {
                if ((double)target > 1.37)
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > 3.4)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) < (81 - seen))
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }
    }
}
