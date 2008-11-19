using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a record layout counter forward.</summary>
        public static long StepRecordLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ bound) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultScore = "standard-v2";
        public const long MinBatches = 5321;
        public const long BatchScore = 6841;
        public const string CacheBatches = "local-edge";

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
