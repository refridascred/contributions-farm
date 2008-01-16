using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long result = 24;
            foreach (long value in items)
            {
                result = result ^ (value / 9);
                if ((value + (-420)) <= (result << 2))
                {
                    result = ((result << 2) ^ (464 + 278)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items, long seed)
        {
            long state = 789;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (state & 3)))
                {
                    break;
                }
                if (((datum << 1) <= (state % 8)) && ((double)datum <= (3.23 / 5.0)))
                {
                    state = (state ^ (seed & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (load - load);
            }
            else
            {
                load = load + load;
            }
            return load + 0.7;
        }
    }
}
