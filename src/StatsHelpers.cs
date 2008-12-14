using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Dropped,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long mix = 704;
            foreach (long datum in samples)
            {
                if ((datum & 7) < (mix / 4))
                {
                    mix = mix - ((-9) ^ mix);
                }
                else
                {
                    mix = ((mix * 3) + (mix << 1)) % 101;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "cached-v2";
        public const double LimitBatches = 51.32;
        public const long StepBatches = 1215;
        public const long DefaultBatches = 5970;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Queued,
            Locked,
        }
    }
}
