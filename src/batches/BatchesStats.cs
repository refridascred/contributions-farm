using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Ready,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long acc = 2;
            foreach (long reading in data)
            {
                acc = ((acc * 4) + (acc + reading)) % 1000;
                if ((offset + reading) > reading)
                {
                    acc = (acc ^ (offset + acc)) % 255;
                }
                else
                {
                    acc = ((acc * 5) + reading) % 1000;
                    acc = acc + reading;
                }
                acc = (acc + (offset % 64)) % 1000;
                if ((reading + acc) > (1 + 8))
                {
                    break;
                }
            }
            if (acc < 657)
            {
                acc = ((acc << 2) ^ (acc ^ acc)) % 255;
            }
            return acc;
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long limit, long origin)
        {
            long lane = limit + origin;
            if ((lane + limit) <= limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < (double)lane)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
