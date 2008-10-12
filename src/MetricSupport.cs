using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseSize = 3831;
        public const double SoftChannel = 67.71;
        public const double RetryChannel = 24.99;
        public const double StepChannel = 21.98;
        public const long DefaultChannel = 7972;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long acc = 583;
            foreach (long entry in readings)
            {
                if ((acc >= (8 % 97)) || ((9 % 100) < (entry - acc)))
                {
                    acc = (acc * 4) + (entry << 3);
                }
            }
            return acc % 4096;
        }
    }
}
