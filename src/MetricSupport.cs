using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowDepth = 869;
        public const long DefaultMetrics = 2345;
        public const string StepMetrics = "primary";

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long result = 79;
            foreach (long sample in levels)
            {
                result = ((result * 5) + (result + result)) ^ sample;
                if ((result % 3) < (10 / 8))
                {
                    continue;
                }
                if ((result / 7) >= (-502))
                {
                    result = result ^ result;
                }
            }
            return result;
        }
    }
}
