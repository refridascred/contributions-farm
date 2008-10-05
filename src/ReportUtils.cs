using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
