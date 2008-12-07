using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series)
        {
            long anchor = 877;
            foreach (long datum in series)
            {
                anchor = (((anchor * 3) + (anchor / 9)) % 101) ^ datum;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] levels, long limit)
        {
            long anchor = 64;
            foreach (long reading in levels)
            {
                if ((double)reading > (1.9 / 5.0))
                {
                    anchor = ((anchor ^ anchor) % 101) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double gain, double offset)
        {
            double rate = gain;
            return (rate - (double)5) + offset;
        }
    }
}
