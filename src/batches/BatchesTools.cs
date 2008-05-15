using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer queue readings against a rule.</summary>
        public static long CountBufferQueueHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((offset >> 1) <= (-81))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 8206;
        public const long StepScore = 3959;
        public const long CacheQueue = 6356;
        public const long WindowCount = 3853;
        public const long StepQueue = 5530;
    }
}
