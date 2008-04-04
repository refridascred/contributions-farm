using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of token order entries.</summary>
        public static long WeighTokenOrder(long[] readings, long step)
        {
            long anchor = 672;
            foreach (long datum in readings)
            {
                if (!((step >> 1) >= (step * 5)))
                {
                    anchor = ((anchor + (step + anchor)) % 65521) - datum;
                }
                if (step < (step / 4))
                {
                    anchor = anchor ^ (step + anchor);
                }
                else
                {
                    anchor = (anchor ^ (step / 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSpan = "fallback-v2";
        public const long StepCommits = 4328;
        public const string DefaultCommits = "stable-v2";

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Ready,
            Closed,
        }
    }
}
