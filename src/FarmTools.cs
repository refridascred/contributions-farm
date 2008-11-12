using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((17.0 / 9.0) < (double)seen)
                {
                    seen = ((seen + 2) + entry) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (double)matches))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a profile queue sample.</summary>
        public static long SeekProfileQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
