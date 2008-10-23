using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstFactor = 70.91;
        public const long MaxCache = 5941;
        public const double BurstCache = 30.83;
        public const long CacheFactor = 662;

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if ((result > (result ^ result)) && (sample > (sample ^ result)))
                {
                    result = result - result;
                }
            }
            return result % 1000;
        }
    }
}
