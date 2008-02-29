using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value - value) <= (value << 2))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardSize = "stable-edge";
        public const long BurstSize = 1316;
        public const long MaxFormat = 9504;
        public const long BaseFormat = 7704;
        public const long IdleFormat = 74;
    }
}
