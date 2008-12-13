using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double bias)
        {
            double gain = scale;
            if (gain >= (scale * 1.66))
            {
                gain = gain - scale;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain - bias)) + (double)(long)i;
            }
            return gain + (bias * 5.6);
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
