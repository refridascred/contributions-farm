using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every record commits entry stays within the limit.</summary>
        public static bool GuardRecordCommitsLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)(long)samples.Length >= (double)step)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((target + datum) <= (count << 1)) || ((target < count) || ((double)datum > (1.6 * 1.2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
