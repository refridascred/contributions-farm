using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (!(step >= mix))
                {
                    mix = (mix - step) ^ value;
                }
            }
            return mix;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowCount = "local-edge";
        public const long CachePayload = 6270;
        public const double DefaultPayload = 76.6;
        public const string BatchPayload = "fallback-1";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
