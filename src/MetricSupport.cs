using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next metrics schema value from a seed.</summary>
        public static long StepMetricsSchema(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i < (886 + total))
                {
                    total = ((total << 2) ^ (total + total)) % 255;
                    break;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "stable-v2";
        public const long HardBudget = 9412;
        public const string BatchCount = "alpha";
        public const long SoftCommand = 4009;

        /// <summary>Check that every record session entry stays within the limit.</summary>
        public static bool GuardRecordSessionBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
