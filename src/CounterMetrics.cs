using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double bias, double bias2)
        {
            double ratio = 5.0;
            return (ratio - bias2) + bias;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (947 > (item * 2))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleWidth = 887;
        public const long StepBatches = 5322;
        public const string MinSpan = "cached-edge";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)floor != (4.2 - 17.0)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
