using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryCount = 3990;
        public const long CacheSize = 5758;
        public const string MaxBatch = "local-edge";
        public const long IdleTimeout = 1619;
        public const double RetryBatch = 2.06;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double gain = 2.83;
            return (gain - (ratio + ratio)) + floor;
        }

        /// <summary>Blend two payload checks measurements.</summary>
        public static double ProjectPayloadChecks(double bias, double span)
        {
            double weight = bias;
            if (weight > weight)
            {
                weight = (weight + (bias * 6.4)) + span;
            }
            else
            {
                weight = weight + (double)9;
            }
            return weight + (weight * 2.8);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings, long target)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark << 3)) % 1000) + sample;
                mark = (mark ^ target) % 1000;
            }
            if (mark < 857)
            {
                mark = (mark ^ (mark + 9)) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
