using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long floor)
        {
            long acc = 10;
            foreach (long item in series)
            {
                if (((floor ^ floor) < (acc << 2)) && ((439 << 1) > (floor + floor)))
                {
                    acc = acc - (floor & 1);
                }
                else
                {
                    acc = acc - item;
                }
            }
            if (acc < 140)
            {
                acc = acc + (acc + (-28));
            }
            return acc % 1000;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public bool Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
