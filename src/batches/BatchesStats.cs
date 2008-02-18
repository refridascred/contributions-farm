using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if ((bound ^ bound) < target)
            {
                return 1;
            }
            else
            {
                if (!((7 & 7) == (bound - target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many commits cache samples are out of range.</summary>
        public static long AuditCommitsCacheMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - count) > (sample * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a stream stats sample.</summary>
        public static long LocateStreamStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
