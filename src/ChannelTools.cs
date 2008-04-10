using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] items, long offset)
        {
            long sum = -971;
            foreach (long value in items)
            {
                sum = (((sum << 3) ^ (5 + value)) % 65521) + offset;
            }
            return sum;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches - floor) < (reading ^ 871))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
