using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!!((floor << 2) <= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double gain, double offset)
        {
            double mean = gain / 7.0;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset * 9.0)) + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            New,
            Idle,
            Closed,
            Synced,
        }
    }
}
