using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchLevel = 9755;
        public const double WindowLevel = 68.52;
        public const long BaseBatches = 7497;
        public const long IdleCount = 2043;
        public const long DefaultBudget = 776;

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double ratio = bias * 8.93;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }
    }
}
