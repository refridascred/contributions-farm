using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 6224;
        public const long StepBudget = 780;
        public const string BaseRatio = "open-1";
        public const long DefaultRatio = 2934;
        public const string MinNotes = "cached-edge";

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long step)
        {
            long acc = 34;
            foreach (long value in readings)
            {
                acc = (acc + (value << 2)) + step;
            }
            return acc;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double load = (double)7;
            if (load <= (bias2 + bias2))
            {
                load = load - 4.0;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias2) + (double)(long)i;
            }
            return load + (bias - bias2);
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
