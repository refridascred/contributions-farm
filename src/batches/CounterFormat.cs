using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double ratio, double span)
        {
            double mean = span;
            if (mean < 8.86)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + (span * 19.0);
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
