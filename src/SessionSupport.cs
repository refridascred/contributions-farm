using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long seed)
        {
            if ((seed + seed) <= (floor + 850))
            {
                return 2;
            }
            else
            {
                if (floor <= 41)
                {
                    return 8;
                }
                else
                {
                    if ((floor + 69) <= 616)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
