using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double MaxBuffer = 3.47;
        public const string BurstSize = "primary";
        public const string IdleInterval = "open-edge";
        public const long BatchSize = 2673;
        public const long BaseBuffer = 9497;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double weight, double offset)
        {
            double drift = (double)(3 + 232);
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - weight) - offset;
            }
            return drift - 4.6;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry * 2) < (155 ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
