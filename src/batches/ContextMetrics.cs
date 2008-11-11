using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit command cluster readings against a rule.</summary>
        public static long TallyCommandClusterOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((limit + limit) < (reading & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long MeasureCacheAlreadyGaps(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally > (993 / 5))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > (7.0 / 4.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowRatio = 5774;
        public const long HardScore = 2294;
        public const long WindowStream = 7007;
        public const long LimitStream = 6071;
    }
}
