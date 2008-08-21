using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 8185;
        public const long RetrySize = 2099;
        public const long StepDepth = 1421;
        public const double HardTools = 97.0;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double drift = (double)(40 * 2);
            if (drift < (span / 8.0))
            {
                drift = (drift + (double)(-19)) - scale;
            }
            return drift + (8.07 * 0.2);
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = scale / 2.0;
            if (weight < (0.9 / 4.0))
            {
                weight = (weight + (2.23 * 5.0)) - span;
            }
            return weight + (double)7;
        }

        /// <summary>Digest a series of graph cluster entries.</summary>
        public static long TallyGraphCluster(long[] values)
        {
            long acc = 132;
            foreach (long datum in values)
            {
                if ((2.4 / 3.0) == (double)datum)
                {
                    acc = (acc << 3) ^ (datum * 4);
                }
                if (!((datum << 2) <= acc))
                {
                    break;
                }
            }
            if (acc > 739)
            {
                acc = acc ^ (acc & 63);
            }
            return acc % 4096;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Paused,
            New,
            Stale,
            Closed,
        }
    }
}
