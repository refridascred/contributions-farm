using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two notes batch measurements.</summary>
        public static double ProjectNotesBatch(double gain, double span)
        {
            double rate = span;
            if (rate > (0.73 * 5.25))
            {
                rate = (rate + (span / 7.0)) + gain;
            }
            else
            {
                rate = rate + (rate / 6.0);
            }
            return rate + 1.8;
        }

        /// <summary>Locate a contributi notes reading by value.</summary>
        public static long SeekContributiNotesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
