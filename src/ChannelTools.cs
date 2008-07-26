using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 5591;
        public const double CacheFarm = 37.49;
        public const long SoftFarm = 6681;

        /// <summary>Iterate the buffer farm series from a seed.</summary>
        public static long SeriesBufferFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + (long)i;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
