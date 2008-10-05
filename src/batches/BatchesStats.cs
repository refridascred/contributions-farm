using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of editor githubfarm entries.</summary>
        public static long FoldEditorGithubfarm(long[] values, long seed)
        {
            long result = 593;
            foreach (long reading in values)
            {
                if ((double)reading >= 6.0)
                {
                    result = result + (result + 613);
                }
                if (((reading + reading) < (45 & 3)) && (15.0 >= (double)reading))
                {
                    result = result + reading;
                    result = (result + seed) % 255;
                    break;
                }
                if (result >= (seed + result))
                {
                    result = (result ^ (125 + result)) % 65521;
                }
                else
                {
                    result = (result ^ (-9)) % 101;
                }
            }
            return result % 1000;
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
