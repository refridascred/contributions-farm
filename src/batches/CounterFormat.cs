using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Locked,
            Active,
            Queued,
            Done,
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 4577;
        public const double DefaultMetric = 63.27;
        public const long WindowMetric = 7808;
        public const string MinTimeout = "legacy-v2";
        public const string BatchMetric = "primary-1";
    }
}
