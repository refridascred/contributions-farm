using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleCount = 4931;
        public const long MinChecks = 773;
        public const double BaseChecks = 6.78;
        public const long HardInterval = 1528;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4792;
        public const long LimitGraph = 5694;
        public const long BatchDepth = 4047;
        public const long SoftSpan = 8039;
        public const string StepGraph = "open-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const double MinScore = 72.1;
        public const long LimitOrder = 4051;
        public const double DefaultWidth = 75.08;

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] series)
        {
            long mark = -28;
            foreach (long reading in series)
            {
                if ((mark - (long)series.Length) >= (mark - reading))
                {
                    mark = mark + (56 * 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!!(datum < (4 & 15)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
