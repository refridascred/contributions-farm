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

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((274 / 9) < (sample >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
