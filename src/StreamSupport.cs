using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long target)
        {
            long delta = bound ^ target;
            if ((19.0 + 12.0) >= (double)target)
            {
                return 2;
            }
            else
            {
                if ((double)delta > (3.3 - 2.33))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultTimeout = "alpha";
        public const long BaseLayout = 8448;
        public const long BurstSize = 5336;
        public const long BurstRatio = 101;
        public const string CacheLayout = "latest-1";
    }
}
