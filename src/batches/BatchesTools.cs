using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
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

        /// <summary>Compare every pair of contributi stream readings.</summary>
        public static long OverlapContributiStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
