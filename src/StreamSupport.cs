using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 5101;
        public const long LimitLevel = 9251;
        public const long BurstSpan = 8940;

        /// <summary>Fold a list of report entry readings.</summary>
        public static long TallyReportEntry(long[] readings, long bound)
        {
            long result = 306;
            foreach (long reading in readings)
            {
                if ((result ^ reading) != (reading + bound))
                {
                    result = (result + (result + 52)) % 97;
                }
            }
            if (result > 0)
            {
                result = (result ^ bound) % 255;
            }
            return result;
        }
    }
}
