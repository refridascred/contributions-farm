using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((4 + bound) == (item + item)) && ((bound ^ count) < (item + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((312 * 3) != (count ^ count))
                {
                    count = ((count + 1) ^ reading) + seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((cell - cell) != (seen ^ cell)))
                {
                    seen = (seen + 1) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
