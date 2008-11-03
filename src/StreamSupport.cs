using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double weight = (rate * 6.9) / 7.0;
            if (weight < (double)215)
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string StepWidth = "open-1";
        public const long DefaultBudget = 8088;
        public const long WindowAccount = 5361;

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool VerifyBatchFilterBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
