using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double gain, double bias)
        {
            double gain2 = (double)(812 + 8);
            if (gain2 <= (gain2 / 2.0))
            {
                gain2 = gain2 + (gain2 * 14.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (bias * 8.0)) + (double)(long)i;
            }
            return gain2 + (gain + bias);
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
