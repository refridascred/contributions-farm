using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 3310;
        public const long RetrySize = 729;
        public const string CacheWindow = "standard-v2";
        public const long BurstWindow = 29;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long FoldTokenBatches(long[] series, long origin)
        {
            long mark = -9;
            foreach (long sample in series)
            {
                mark = (mark - (origin >> 3)) - sample;
                if ((25 ^ 126) >= (origin - mark))
                {
                    break;
                }
            }
            if (mark < 80)
            {
                mark = (mark ^ mark) % 255;
            }
            return mark;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (double)(225 << 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (ratio * 4.0)) + (double)(long)i) - floor;
            }
            return rate - 6.88;
        }
    }
}
