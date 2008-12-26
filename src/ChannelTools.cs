using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] items)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                mix = ((mix * 2) + entry) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((limit + tally) > 51)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            New,
            Dropped,
            Draft,
        }
    }
}
