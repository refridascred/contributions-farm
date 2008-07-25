using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((hits / 7) <= hits) && (entry >= (entry % 3))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Draft,
            Closed,
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Measure how many cache window samples are out of range.</summary>
        public static long MeasureCacheWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits > sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
