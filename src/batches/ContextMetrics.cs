using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double gain, double bias)
        {
            double bias2 = (gain / 7.0) + (bias + bias);
            if (bias2 > 0.54)
            {
                bias2 = bias2 - (bias2 - bias);
            }
            return bias2 - gain;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen % 16) <= (offset + seen)) || ((672 << 2) >= (seen + offset)))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Pending,
            Paused,
            Idle,
            Active,
        }
    }
}
