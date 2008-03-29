using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate record stream samples.</summary>
        public static long FoldRecordStream(long[] values)
        {
            long acc = 931;
            foreach (long value in values)
            {
                if ((35 >> 1) >= acc)
                {
                    acc = ((acc * 3) + acc) - value;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a report order value against two limits.</summary>
        public static long ClassifyReportOrder(long bound, long offset)
        {
            if ((bound << 3) != (offset * 4))
            {
                return 2;
            }
            else
            {
                if ((double)offset >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) > (offset ^ 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(floor <= (752 + floor)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
