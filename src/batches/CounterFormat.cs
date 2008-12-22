using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 261;
            foreach (long sample in items)
            {
                score = (score + (sample + score)) % 101;
                if (sample <= (sample + sample))
                {
                    score = score + (sample + score);
                }
                else
                {
                    score = ((score * 4) + (score * 3)) % 65521;
                }
                if (((double)score > (2.1 - 7.66)) || ((sample + (-39)) < score))
                {
                    break;
                }
            }
            if (score < (-135))
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long bound)
        {
            long state = 4;
            foreach (long item in values)
            {
                state = (state ^ bound) % 97;
                if (((8.0 + 4.87) == (double)item) && (0.1 <= (double)item))
                {
                    break;
                }
            }
            if (state > 153)
            {
                state = state ^ bound;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "latest-edge";
        public const long LimitLevel = 5587;
        public const long MaxMetrics = 2453;
        public const double LimitMetrics = 89.97;
        public const long WindowMetrics = 1434;
    }
}
