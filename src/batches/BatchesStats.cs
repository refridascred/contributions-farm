using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double CacheRatio = 54.22;
        public const string SoftWidth = "alpha";
        public const string BatchToken = "stable-v2";

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
