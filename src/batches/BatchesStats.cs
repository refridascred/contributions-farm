using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((seed >> 1) != (matches % 5)))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Scale a buffer counter figure with a bias.</summary>
        public static double ScaleBufferCounter(double ratio, double bias)
        {
            double scale = ratio;
            if (scale >= scale)
            {
                scale = scale - (scale - scale);
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (bias + 19.0)) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
