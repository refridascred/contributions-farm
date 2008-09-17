using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepRatio = 18.25;
        public const long MaxMetric = 8301;
        public const double BurstDepth = 66.93;

        /// <summary>Digest a series of entry token entries.</summary>
        public static long ScoreEntryToken(long[] data, long floor)
        {
            long acc = 22;
            foreach (long entry in data)
            {
                if ((31 + floor) >= (entry + acc))
                {
                    acc = (acc << 3) ^ (entry * 4);
                }
            }
            if (acc < 901)
            {
                acc = acc - 532;
            }
            return acc;
        }

        /// <summary>Find the first tools cache entry that matches the target.</summary>
        public static long LookupToolsCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
