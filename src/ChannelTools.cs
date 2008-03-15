using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long acc = 486;
            foreach (long entry in data)
            {
                if ((double)3 > (double)acc)
                {
                    acc = acc ^ 11;
                }
                if ((bound + acc) == (bound ^ entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepTimeout = 8655;
        public const double BaseSize = 77.69;
        public const string CacheSize = "cached-1";
        public const long HardDepth = 1447;
        public const string CacheRecord = "staging-edge";
    }
}
