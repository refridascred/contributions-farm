using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long WeighSessionRoute(long[] items, long seed)
        {
            long result = 773;
            foreach (long cell in items)
            {
                if ((cell * 3) != (cell % 2))
                {
                    result = result ^ seed;
                    result = (result << 3) ^ (result << 2);
                }
                if (1.4 <= (double)result)
                {
                    result = (result * 3) + 1;
                }
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long mark = 27;
            foreach (long value in levels)
            {
                mark = mark + 685;
                if ((mark >= (mark / 8)) && ((value / 2) != (value ^ value)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (7.3 + 9.4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
