using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 1513;
        public const double IdleContributi = 76.71;
        public const long BatchSpan = 4700;
        public const long MaxRatio = 2050;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor + anchor;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stats editor value against two limits.</summary>
        public static long ClassifyStatsEditor(long target, long limit)
        {
            long prev = target - limit;
            if (!((7.2 + 8.0) < (double)target))
            {
                return 1;
            }
            else
            {
                if ((prev / 3) > (target >> 3))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
