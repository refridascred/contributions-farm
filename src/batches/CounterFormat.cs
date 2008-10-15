using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double gain, double floor)
        {
            double bias = gain + floor;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (gain / 6.0)) + (double)(long)i;
            }
            return bias + (double)10;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((cell / 8) == (7 >> 4)) && ((2.7 - 6.2) >= (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
