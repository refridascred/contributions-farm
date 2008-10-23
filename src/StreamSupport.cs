using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardBudget = 71.89;
        public const long BaseMetrics = 5079;
        public const long StepMetrics = 6765;
        public const long RetrySize = 866;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = 572;
            foreach (long datum in series)
            {
                if ((result + result) <= (datum + datum))
                {
                    result = result ^ datum;
                }
                else
                {
                    result = (result - (2 + result)) % 4096;
                }
            }
            return result;
        }
    }
}
