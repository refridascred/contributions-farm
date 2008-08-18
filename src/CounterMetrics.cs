using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 9024;
        public const long CacheCounter = 1330;
        public const long StepCounter = 333;
        public const long DefaultCounter = 8430;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double scale, double floor)
        {
            double weight = floor;
            return (weight - weight) + scale;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Active,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Combine stream layout values into a single score.</summary>
        public static long ScoreStreamLayout(long[] series, long offset)
        {
            long total = 716;
            foreach (long value in series)
            {
                if (((total + offset) == (value + (-3))) || ((offset ^ value) < offset))
                {
                    total = ((total << 2) ^ (total >> 5)) % 65521;
                }
                if ((value - offset) < (value + total))
                {
                    break;
                }
            }
            return total;
        }
    }
}
