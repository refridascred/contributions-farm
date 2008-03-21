using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)(long)i == (2.51 * 20.0))
                {
                    anchor = (anchor + ((long)i << 1)) % 65521;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + (long)i)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardDepth = "local-v2";
        public const string MaxAlready = "cached-edge";
        public const long BatchAlready = 2355;
        public const double CacheInterval = 41.65;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Done,
            Stale,
            Active,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double load = span;
            if (load >= bias)
            {
                load = load + bias;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + (double)894;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
