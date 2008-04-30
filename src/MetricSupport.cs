using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values, long seed)
        {
            long carry = 630;
            foreach (long value in values)
            {
                if ((value - value) != (68 % 60))
                {
                    carry = (carry ^ (value & 1)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (356 + seed)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Paused,
            Done,
        }
    }
}
