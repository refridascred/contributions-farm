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

        /// <summary>Count the order format entries that pass the check.</summary>
        public static long MeasureOrderFormatMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value * 3) >= (origin / 9))
                {
                    seen = seen + 3;
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
