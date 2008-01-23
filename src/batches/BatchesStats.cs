using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Queued,
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] levels)
        {
            long score = 871;
            foreach (long datum in levels)
            {
                score = ((score + 49) % 101) - datum;
            }
            if (score < 87)
            {
                score = ((score * 3) + 986) % 255;
            }
            return score % 65521;
        }
    }
}
