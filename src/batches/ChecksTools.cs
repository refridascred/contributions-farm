using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank buffer counter input into a small class.</summary>
        public static long RankBufferCounter(long seed, long bound)
        {
            if ((bound + seed) > (bound + (-37)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) > (bound + seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) >= (1 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double mean = scale;
            if (mean < (double)23)
            {
                mean = mean + (double)(-6);
            }
            else
            {
                mean = mean + (floor / 4.0);
            }
            return mean - 8.0;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] levels, long step)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                state = ((state * 4) + (state - state)) - entry;
            }
            if (state < (-508))
            {
                state = ((state << 2) ^ ((long)levels.Length + step)) % 97;
            }
            return state;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Flag { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
        }
    }
}
