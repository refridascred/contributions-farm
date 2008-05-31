using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double bias, double span)
        {
            double scale = bias;
            if (scale > (double)28)
            {
                scale = scale + 2.08;
            }
            return scale + span;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 142;
            foreach (long sample in readings)
            {
                if (((total / 2) > (total - sample)) || (sample < (total * 5)))
                {
                    total = (total ^ (total & 3)) % 101;
                }
                else
                {
                    total = (total * 4) + sample;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 9869;
        public const long MinBudget = 8257;
        public const long SoftTimeout = 922;
    }
}
