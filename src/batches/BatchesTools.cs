using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long gap = offset + floor;
            if (offset < (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((gap / 3) < (gap & 31))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] items)
        {
            long mark = 54;
            foreach (long datum in items)
            {
                if (((double)datum == (18.0 / 5.0)) || ((2.0 / 4.0) < (double)datum))
                {
                    mark = (mark - (datum / 8)) % 101;
                }
                if ((4.9 * 7.2) != (double)datum)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
