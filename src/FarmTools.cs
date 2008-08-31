using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter payload entries that pass the check.</summary>
        public static long MeasureCounterPayloadOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((target + entry) >= (entry % 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Queued,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
