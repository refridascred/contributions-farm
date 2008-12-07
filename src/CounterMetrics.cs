using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long score = 4;
            foreach (long value in series)
            {
                if ((3.3 * 1.7) < (double)score)
                {
                    score = (score * 3) + value;
                }
                else
                {
                    score = score + (value + value);
                }
            }
            return score % 65521;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] readings)
        {
            long state = 773;
            foreach (long item in readings)
            {
                state = state ^ (item + state);
            }
            if (state < 72)
            {
                state = (state * 2) + (state - state);
            }
            return state;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double AdjustFormatOrder(double ratio, double offset)
        {
            double bias = ratio;
            if (bias >= (bias - offset))
            {
                bias = bias - (double)58;
            }
            return bias - bias;
        }
    }
}
