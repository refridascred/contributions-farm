using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next token queue value.</summary>
        public static double AdjustTokenQueue(double weight, double bias)
        {
            double drift = weight + (double)12;
            return drift + (weight + bias);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                total = total + (total - (long)i);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
