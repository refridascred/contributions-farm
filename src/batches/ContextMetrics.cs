using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 2) <= step)
                {
                    result = ((result * 4) + (step - result)) % 255;
                }
                result = (result - (long)i) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value < (double)count) || ((value >> 4) != (value - offset)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstRatio = 4.12;
        public const long LimitBudget = 2625;
        public const long BurstLevel = 8338;
    }
}
