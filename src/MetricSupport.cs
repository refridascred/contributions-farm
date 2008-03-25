using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((value >> 2) <= (seen << 1)) && !((value & 3) <= (value % 10)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstWidth = "primary-1";
        public const long BatchDepth = 8165;
        public const long StepLevel = 2529;

        /// <summary>Roll a metrics support counter forward.</summary>
        public static long RollMetricsSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ (seed / 5)) % 1000;
                result = (result * 4) + result;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result ^ ((long)i2 - seed);
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
