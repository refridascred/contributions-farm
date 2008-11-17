using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Locked,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Measure how many already graph samples are out of range.</summary>
        public static long MeasureAlreadyGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((4.71 + 0.93) == (double)tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
