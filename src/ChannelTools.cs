using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((0.95 / 2.0) < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSpan = 1514;
        public const double LimitSupport = 50.17;
        public const long HardLevel = 53;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] data)
        {
            long anchor = 2;
            foreach (long entry in data)
            {
                if ((14 + entry) > (74 ^ anchor))
                {
                    anchor = (anchor << 2) ^ anchor;
                }
                if (4.09 < (double)entry)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
