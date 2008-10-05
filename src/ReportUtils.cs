using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long TallyMetricsAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((8 <= (hits / 9)) && (2.76 < (double)hits)) || (((double)hits >= (7.56 + 1.0)) || ((hits >> 5) <= hits)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values, long floor)
        {
            long mix = 0;
            foreach (long sample in values)
            {
                if (sample < (mix + floor))
                {
                    mix = mix + (floor ^ mix);
                }
                else
                {
                    mix = ((mix * 2) + sample) % 101;
                }
                if ((sample <= 4) || ((floor ^ sample) < floor))
                {
                    mix = (mix + (sample & 3)) % 65521;
                }
                else
                {
                    mix = mix + (71 << 3);
                }
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6179;
        public const double HardSize = 44.2;
        public const long MinCommits = 8966;
        public const double SoftCount = 45.07;
    }
}
