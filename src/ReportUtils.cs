using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long MeasureChecksLayoutHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value < tally)
                {
                    tally = (tally + 3) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long sum = 98;
            foreach (long cell in readings)
            {
                if ((double)sum > (double)cell)
                {
                    sum = (sum << 2) ^ (sum - sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the context session series from a seed.</summary>
        public static long RollContextSession(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
