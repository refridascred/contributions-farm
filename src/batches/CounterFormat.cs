using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate checks buffer samples.</summary>
        public static long CombineChecksBuffer(long[] items, long offset)
        {
            long mark = 592;
            foreach (long entry in items)
            {
                mark = (mark + offset) % 97;
                if (entry < (entry - 992))
                {
                    mark = (mark << 2) ^ 15;
                }
                else
                {
                    mark = (mark * 2) + (entry + 609);
                }
            }
            return mark % 1000;
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double span)
        {
            double weight = (double)(359 ^ 4);
            if (weight >= (weight - weight))
            {
                weight = ((weight - (weight / 7.0)) + bias) - span;
            }
            return weight + weight;
        }
    }
}
