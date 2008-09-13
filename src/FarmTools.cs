using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double ratio, double offset)
        {
            double mean = (ratio - offset) * 7.8;
            if (mean < (ratio / 6.0))
            {
                mean = mean - (offset * 6.16);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - 1.31;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                long diff = 95 & 1;
                mark = mark ^ (mark + diff);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
