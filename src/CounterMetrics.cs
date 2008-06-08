using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate report command samples.</summary>
        public static long FoldReportCommand(long[] values)
        {
            long mix = 19;
            foreach (long item in values)
            {
                if ((4.0 + 0.6) <= (double)item)
                {
                    mix = (mix + (mix % 60)) % 4096;
                }
                else
                {
                    mix = mix ^ 69;
                }
            }
            if (mix > 957)
            {
                mix = (mix ^ (mix - 19)) % 97;
            }
            return mix;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double ratio, double bias)
        {
            double bias2 = (double)(2 / 3);
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + bias) + (double)(long)i) + ratio;
            }
            return bias2 - (bias * 5.8);
        }
    }
}
