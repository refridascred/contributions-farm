using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long AuditAccountWindowGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (floor < (floor - count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 2) >= (reading / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepInterval = 8172;
        public const long RetryDepth = 1307;
        public const long IdleBudget = 4662;
        public const long SoftSize = 2866;
        public const long HardSpan = 9853;

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
