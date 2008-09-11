using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double scale = 2.34;
            if (scale > (double)15)
            {
                scale = ((scale - (double)575) - bias) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 7.0)) - (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
