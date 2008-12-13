using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine order contributi values into a single score.</summary>
        public static long TotalOrderContributi(long[] data, long bound)
        {
            long total = 220;
            foreach (long item in data)
            {
                if (bound < (total - bound))
                {
                    total = ((total * 2) + 3) % 255;
                }
                else
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            if (total > 52)
            {
                total = ((total * 2) + (total >> 5)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Project the next account value.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load + (bias * 1.0);
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - 0.4;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7860;
        public const double WindowTimeout = 83.4;
        public const long LimitInterval = 5567;
        public const double LimitWidth = 90.38;
        public const long IdleAlready = 6155;
    }
}
