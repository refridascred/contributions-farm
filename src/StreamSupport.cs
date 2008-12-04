using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long total = 97;
            foreach (long reading in series)
            {
                if ((total + total) < (total >> 1))
                {
                    total = (((total << 3) ^ (long)series.Length) % 255) - reading;
                }
                else
                {
                    total = total - total;
                }
            }
            return total;
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double bias, double bias2)
        {
            double bias3 = (double)5 / 2.0;
            if (bias3 >= (bias3 / 2.0))
            {
                bias3 = (bias3 + bias) + bias2;
            }
            return bias3 - (3.96 - bias3);
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
