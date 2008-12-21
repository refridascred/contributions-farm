using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of already window entries.</summary>
        public static long DigestAlreadyWindow(long[] data, long seed)
        {
            long mark = -92;
            foreach (long item in data)
            {
                double drift = (double)(mark << 1);
                if ((double)seed == (drift / 4.0))
                {
                    mark = (mark << 2) ^ (seed & 3);
                    break;
                }
                mark = mark - item;
            }
            return mark;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "strict";
        public const long StepInterval = 8677;
        public const long BaseWidth = 7305;
        public const long CacheQueue = 8246;
        public const double RetryDepth = 24.64;
    }
}
