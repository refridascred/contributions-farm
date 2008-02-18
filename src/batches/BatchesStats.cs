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

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data)
        {
            long mix = 5;
            foreach (long entry in data)
            {
                if (entry < (mix % 2))
                {
                    mix = ((mix * 2) + mix) % 1000;
                }
            }
            return mix;
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
