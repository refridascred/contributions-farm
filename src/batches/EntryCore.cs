using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 1.03;
        public const long LimitCommand = 8446;
        public const long SoftScore = 1787;
        public const long HardCount = 6985;
        public const double SoftCommand = 73.99;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (scale2 - scale))
            {
                scale2 = scale2 - 0.9;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - (span * 13.0);
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
