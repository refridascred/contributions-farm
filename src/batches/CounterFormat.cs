using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double load = (double)(4 + 108);
            return (load - (offset * 8.9)) + bias;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long MeasureFormatRouteGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit - 6) <= (tally + tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }
    }
}
