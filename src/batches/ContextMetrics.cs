using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 8191;
        public const long WindowSupport = 2071;
        public const long StepSupport = 9618;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 4640;
        public const string MinSpan = "strict-v2";
        public const string WindowQueue = "stable-1";
        public const long IdleScore = 2393;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value * 2) == (67 << 2))
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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ seed) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
