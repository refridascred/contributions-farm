using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry < (double)target) || ((double)entry < (13.0 * 7.1))) || ((double)target > (6.0 + 16.0)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double ratio, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - ratio;
            }
            return gain - (double)4;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((9.06 / 5.0) > (double)seen)
                {
                    seen = ((seen + 2) ^ cell) + target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] data, long bound)
        {
            long carry = 105;
            foreach (long datum in data)
            {
                carry = ((((carry * 4) + (9 % 2)) % 97) + datum) + bound;
            }
            return carry;
        }
    }
}
