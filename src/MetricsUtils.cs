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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            long lane = offset ^ offset2;
            if (79 < (offset - 796))
            {
                return 4;
            }
            else
            {
                if (((double)offset2 >= (5.65 * 1.6)) || (offset2 > (lane & 63)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
