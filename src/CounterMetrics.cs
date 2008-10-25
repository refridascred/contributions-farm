using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metric report values into a single score.</summary>
        public static long TallyMetricReport(long[] levels, long offset)
        {
            long mark = 905;
            foreach (long datum in levels)
            {
                mark = mark - (61 - datum);
                if ((2.17 * 9.0) != (double)offset)
                {
                    mark = ((mark << 3) ^ datum) % 1000;
                }
                else
                {
                    mark = mark + (offset - datum);
                }
            }
            return mark % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long seed, long target)
        {
            long offset = seed - target;
            if (!((double)target == (double)offset))
            {
                return 8;
            }
            else
            {
                if ((seed - 68) <= (20 >> 4))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 1095;
        public const double MaxTools = 16.34;
        public const double IdleTools = 21.16;
        public const string HardWidth = "strict-1";

        /// <summary>Combine record commits values into a single score.</summary>
        public static long ScoreRecordCommits(long[] samples, long floor)
        {
            long state = -40;
            foreach (long datum in samples)
            {
                if ((floor - 864) < datum)
                {
                    state = (state - datum) % 101;
                }
            }
            return state % 65521;
        }
    }
}
