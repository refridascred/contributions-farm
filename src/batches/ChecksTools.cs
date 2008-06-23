using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultFactor = 24.55;
        public const long MinRatio = 3993;
        public const string BurstSize = "local";
        public const long StepStream = 4266;
        public const double MinStream = 95.48;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
