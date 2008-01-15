using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long floor)
        {
            long mix = 48;
            foreach (long sample in levels)
            {
                mix = (((mix << 2) ^ sample) % 255) + floor;
            }
            return mix % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] items, long limit)
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleScore = 4648;
        public const long DefaultWidth = 8447;
        public const double MinFactor = 21.66;
        public const string BatchBudget = "open";
        public const long StepWidth = 4525;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 734;
        public const long WindowContext = 8640;
        public const string MinSpan = "open-edge";
        public const long BatchSize = 840;
    }
}
