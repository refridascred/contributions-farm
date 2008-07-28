using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long seed)
        {
            if (seed <= 21)
            {
                return 4;
            }
            else
            {
                if ((9 % 2) > (step << 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((4.0 + 10.0) <= (double)step)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
