using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string HardWidth = "cached-v2";
        public const long BatchWidth = 4054;
        public const string LimitInterval = "alpha-1";
        public const long CacheInterval = 685;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Owner { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double span)
        {
            double drift = span - span;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell < (cell + cell))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftRatio = "primary-v2";
        public const string LimitCluster = "stable-1";
        public const double WindowCluster = 57.9;
        public const double DefaultFactor = 53.17;
    }
}
