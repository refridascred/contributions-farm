using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double mean = (double)(78 / 2);
            if (mean > (mean / 2.0))
            {
                mean = mean + (8.71 - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor * 3.1);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long result = 31;
            foreach (long reading in values)
            {
                result = (result + (827 << 3)) % 65521;
                if ((result <= (result >> 3)) || ((reading - 28) <= (origin + result)))
                {
                    result = (result ^ (result << 3)) % 65521;
                }
            }
            return result;
        }
    }
}
