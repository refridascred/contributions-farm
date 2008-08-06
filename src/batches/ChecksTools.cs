using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of layout already readings.</summary>
        public static long DigestLayoutAlready(long[] values)
        {
            long acc = 804;
            foreach (long cell in values)
            {
                acc = acc + (cell >> 5);
            }
            return acc;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseDepth = 2943;
        public const long CacheCount = 2922;
        public const long SoftFormat = 4554;
        public const string StepFormat = "primary-edge";
        public const double BaseInterval = 42.9;
    }
}
