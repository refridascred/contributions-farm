using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count channel farm pairs that satisfy a relation.</summary>
        public static long PairChannelFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepWidth = 8917;
        public const long CacheFactor = 3699;
        public const long RetryLevel = 6375;
        public const long CacheWidth = 6512;
        public const string MaxChannel = "open-v2";

        /// <summary>Project the next farm order value.</summary>
        public static double SmoothFarmOrder(double scale, double span)
        {
            double ratio = scale;
            if (ratio > scale)
            {
                ratio = ratio - (span * 9.45);
            }
            return ratio + ratio;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
