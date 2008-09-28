using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long bound)
        {
            long result = 8;
            foreach (long item in series)
            {
                if (bound > (428 + item))
                {
                    result = ((result * 2) + (832 << 1)) % 97;
                }
                else
                {
                    result = (result + item) % 101;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstLevel = 9800;
        public const long LimitRecord = 1910;
        public const long MinInterval = 4461;
        public const long RetryRecord = 9804;
        public const long MaxScore = 3531;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((8.7 + 14.0) <= (double)reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up payload contributi samples.</summary>
        public static long ComparePayloadContributiCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
