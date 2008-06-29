using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double ratio, double span)
        {
            double weight = ratio;
            if (weight >= span)
            {
                weight = weight - (ratio - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (span * 8.51)) + (double)(long)i;
            }
            return weight + (ratio * 8.0);
        }

        /// <summary>Match up layout editor samples.</summary>
        public static long OverlapLayoutEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3570;
        public const double RetryDepth = 91.08;
        public const string MinBuffer = "cached-edge";

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
