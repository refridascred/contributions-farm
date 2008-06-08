using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double weight = (double)75 / 2.0;
            if (weight > (2.7 / 3.0))
            {
                weight = (weight - (weight + rate)) + span;
            }
            return weight + rate;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a order contributi figure with a bias.</summary>
        public static double ProjectOrderContributi(double gain, double floor)
        {
            double ratio = floor + (12.0 + gain);
            if (ratio <= gain)
            {
                ratio = ratio + (gain + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - gain) + (double)(long)i;
            }
            return ratio - (ratio - gain);
        }
    }
}
