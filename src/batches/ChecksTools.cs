using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((0.72 / 9.0) > (double)origin)
                {
                    mark = (mark - origin) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
