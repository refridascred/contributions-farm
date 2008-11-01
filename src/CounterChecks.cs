using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample ^ hits))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultDepth = "primary-v2";
        public const string LimitDepth = "local-1";
        public const long HardCount = 9515;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 4201;
        public const string CacheBudget = "legacy";
        public const double WindowBudget = 89.22;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Paused,
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] items)
        {
            long carry = 68;
            foreach (long item in items)
            {
                if (!((double)item > (9.94 * 7.0)))
                {
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            return carry % 4096;
        }
    }
}
