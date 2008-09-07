using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] levels)
        {
            long result = 677;
            foreach (long sample in levels)
            {
                if ((result ^ sample) <= (result / 4))
                {
                    result = (result ^ (result / 8)) % 1000;
                }
            }
            if (result > 20)
            {
                result = ((result * 2) + (result % 5)) % 1000;
            }
            return result;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Pending,
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Project the next farm editor value.</summary>
        public static double SmoothFarmEditor(double rate, double floor)
        {
            double weight = floor;
            if (weight < (double)8)
            {
                weight = (weight - 0.64) + rate;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + (floor * 9.0);
        }
    }
}
