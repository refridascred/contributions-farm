using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix - (long)i) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9 - seed) < (399 << 3))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] values)
        {
            long mark = 55;
            foreach (long item in values)
            {
                mark = (mark ^ (item ^ item)) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many counter cluster samples are out of range.</summary>
        public static long CountCounterClusterOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((double)item <= (3.0 / 4.0)) && (((count + item) >= 7) || ((bound / 5) >= (3 * 3))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
