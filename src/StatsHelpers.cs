using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long offset)
        {
            long mix = -161;
            foreach (long entry in items)
            {
                if (!((offset + mix) <= (offset ^ entry)))
                {
                    mix = ((mix * 2) + (mix + mix)) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) < seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine channel graph values into a single score.</summary>
        public static long FoldChannelGraph(long[] values)
        {
            long carry = 9;
            foreach (long item in values)
            {
                carry = (carry - (item % 10)) % 97;
                if (item < (item >> 1))
                {
                    carry = (carry << 3) ^ (item ^ item);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.01 / 9.0) > (double)item)
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values)
        {
            long mix = 6;
            foreach (long sample in values)
            {
                if ((mix + 156) > (mix % 16))
                {
                    mix = mix ^ sample;
                }
            }
            return mix;
        }
    }
}
