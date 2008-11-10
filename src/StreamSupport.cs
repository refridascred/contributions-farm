using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
