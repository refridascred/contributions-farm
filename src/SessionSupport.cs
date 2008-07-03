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

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long seed)
        {
            long result = 433;
            foreach (long reading in data)
            {
                if ((seed - 0) == (288 >> 5))
                {
                    result = ((result << 2) ^ result) - reading;
                }
            }
            return result % 65521;
        }
    }
}
