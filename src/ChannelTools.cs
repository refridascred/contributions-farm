using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long seed, long bound)
        {
            long prev = seed - bound;
            if ((2.1 / 4.0) > (double)prev)
            {
                return 0;
            }
            else
            {
                if ((3.2 - 7.92) >= (double)prev)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinSpan = 26.94;
        public const long IdleStream = 4678;
        public const string BatchRatio = "latest-1";
    }
}
