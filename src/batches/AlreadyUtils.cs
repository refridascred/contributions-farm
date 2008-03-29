using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] levels, long bound)
        {
            long state = 212;
            foreach (long cell in levels)
            {
                state = ((state ^ (state >> 1)) ^ cell) - bound;
            }
            return state % 97;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double scale, double span)
        {
            double rate = (double)618 - span;
            if (rate < (double)641)
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(-4)) + (double)(long)i;
            }
            return rate - (scale + rate);
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item + matches) <= item) && !((218 - 32) > item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Dropped,
            Closed,
            Retry,
        }
    }
}
