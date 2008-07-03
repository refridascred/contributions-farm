using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Paused,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double mean = 0.76;
            if (mean <= (offset - mean))
            {
                mean = (mean + mean) - weight;
            }
            else
            {
                mean = mean + (offset * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - 2.8;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
