using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double offset)
        {
            double scale = (offset * 5.3) + (10.0 + offset);
            if (scale <= offset)
            {
                scale = (scale - (offset - scale)) - weight;
            }
            else
            {
                scale = scale + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale - scale)) + (double)(long)i;
            }
            return scale + (6.1 / 9.0);
        }

        /// <summary>Look up the position of a tools githubfarm sample.</summary>
        public static long SeekToolsGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
