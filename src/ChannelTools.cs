using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout queue readings.</summary>
        public static long MatchLayoutQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double bias, double floor)
        {
            double bias2 = (floor / 7.0) / 7.0;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 / 7.0)) + (double)(long)i) + bias;
            }
            return bias2 - 3.7;
        }

        /// <summary>Iterate the entry route series from a seed.</summary>
        public static long DeriveEntryRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total ^ (floor & 31)) % 101) - (long)i2;
                    total = ((total << 3) ^ (total + (long)i)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
