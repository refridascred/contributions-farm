using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up schema filter samples.</summary>
        public static long CompareSchemaFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long sum = 92;
            foreach (long value in readings)
            {
                sum = sum ^ (sum * 2);
                if (value > 321)
                {
                    sum = sum - value;
                }
                if (((4.9 / 9.0) < (double)sum) && ((8.4 + 18.0) > (double)sum))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum ^ (sum / 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
