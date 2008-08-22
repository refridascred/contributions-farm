using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Active,
            Draft,
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
