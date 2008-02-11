using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the record channel series from a seed.</summary>
        public static long StepRecordChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                long tally = floor + (mark >> 4);
                if ((((long)i % 12) != (long)i) || (((long)i - 54) >= tally))
                {
                    mark = ((mark << 3) ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a stream metric figure with a bias.</summary>
        public static double AdjustStreamMetric(double rate, double span)
        {
            double mean = span;
            return (mean - span) + rate;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
