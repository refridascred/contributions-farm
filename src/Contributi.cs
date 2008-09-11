using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double ratio, double floor)
        {
            double weight = (3.0 / 9.0) - 9.25;
            if (weight <= (weight - weight))
            {
                weight = (weight + (weight * 1.3)) - floor;
            }
            else
            {
                weight = weight - (15.0 + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (4.95 * 0.12)) - (double)(long)i;
            }
            return weight + 6.3;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((sample + hits) < hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryInterval = 3763;
        public const long CacheInterval = 882;
        public const double DefaultCluster = 81.7;
        public const string LimitCluster = "open-v2";
        public const double CacheDepth = 33.8;

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
