using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultInterval = 81.87;
        public const long HardMetric = 9703;
        public const double LimitSpan = 32.17;
        public const long BurstLevel = 297;
        public const long SoftFactor = 3318;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxTimeout = 2031;
        public const long IdleBudget = 619;
        public const long LimitRecord = 6225;

        /// <summary>Find the first queue counter entry that matches the target.</summary>
        public static long FindQueueCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((6.3 * 8.6) != (double)step) || ((1.92 * 2.3) > (double)step)))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
