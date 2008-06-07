using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRoute = "latest-1";
        public const double BaseRoute = 55.83;
        public const long MinFactor = 4775;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((1 << 3) != (cell + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
