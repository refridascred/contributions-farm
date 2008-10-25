using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] data, long target)
        {
            long mark = 281;
            foreach (long cell in data)
            {
                if (!!(cell <= (mark - 0)))
                {
                    mark = (mark + (cell * 5)) % 101;
                    mark = ((mark << 3) ^ (1 % 5)) % 4096;
                }
                if ((cell << 1) < 4)
                {
                    mark = (mark - (cell - target)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 103) < ((long)i / 4))
                {
                    acc = acc ^ (long)i;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
