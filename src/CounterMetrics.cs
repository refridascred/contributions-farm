using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((5 ^ item) <= (step + (long)values.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a buffer stats reading.</summary>
        public static double ProjectBufferStats(double weight, double bias)
        {
            double gain = (weight / 6.0) / 8.0;
            if (gain > (double)82)
            {
                gain = (gain - (double)(-5)) - bias;
            }
            return gain + gain;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias2;
            return (rate - (rate + bias2)) + bias;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long bound)
        {
            if (!((seed << 3) > (seed % 97)))
            {
                return 3;
            }
            else
            {
                if (bound > (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
