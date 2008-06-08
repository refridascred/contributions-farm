using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Roll a payload command counter forward.</summary>
        public static long SeriesPayloadCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if ((9.5 - 11.0) > (double)bound)
                {
                    acc = acc + (long)i;
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
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
