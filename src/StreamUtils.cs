using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseFactor = 9281;
        public const string BurstScore = "open-edge";
        public const long BurstCluster = 6697;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item + (-967))) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Check that every editor payload entry stays within the limit.</summary>
        public static bool CheckEditorPayloadBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - weight) - (double)(long)i) - span;
            }
            return mean - weight;
        }
    }
}
