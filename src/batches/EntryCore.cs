using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 6916;
        public const long BatchTools = 8690;
        public const double MinTimeout = 55.16;
        public const long LimitTools = 3164;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 1193;
        public const string RetryWindow = "local-1";
        public const string DefaultWindow = "primary";
        public const double LimitSize = 84.63;
    }
}
