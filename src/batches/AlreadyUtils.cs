using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] samples, long target)
        {
            long mark = 429;
            foreach (long reading in samples)
            {
                if (mark <= (target + mark))
                {
                    mark = ((mark - (mark ^ target)) % 255) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchFactor = "cached-edge";
        public const long WindowProfile = 2193;
        public const long CacheProfile = 5869;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Ready,
            Queued,
            Closed,
            Done,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                if ((59 + total) == (2 + (-208)))
                {
                    total = total ^ total;
                }
                if ((sample * 3) > (long)samples.Length)
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total << 3) ^ (total / 8);
            }
            return total % 4096;
        }
    }
}
