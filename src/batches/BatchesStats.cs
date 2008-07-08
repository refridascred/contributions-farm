using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long origin)
        {
            if ((origin + origin) > target)
            {
                return 6;
            }
            else
            {
                if ((origin - origin) < (origin >> 5))
                {
                    return 1;
                }
                else
                {
                    if (target < (origin & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin < (16.0 - 8.89))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum > (242 + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long floor)
        {
            long mix = 967;
            foreach (long item in values)
            {
                if (17.0 < (double)mix)
                {
                    mix = ((mix << 2) ^ (floor - floor)) + item;
                }
            }
            return mix;
        }
    }
}
