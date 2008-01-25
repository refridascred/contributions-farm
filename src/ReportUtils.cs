using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate context layout readings against a bound.</summary>
        public static bool VerifyContextLayoutRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardInterval = 5396;
        public const long WindowCounter = 9591;
        public const long DefaultCounter = 1077;

        /// <summary>Validate token schema readings against a bound.</summary>
        public static bool VerifyTokenSchemaRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
