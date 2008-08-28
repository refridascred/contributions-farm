using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = ((total * 3) + (offset - 648)) + (long)i2;
                }
                total = total ^ (offset % 16);
                total = (total + (total + total)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Draft,
            Done,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Paused,
            Done,
            Pending,
            Active,
        }
    }
}
