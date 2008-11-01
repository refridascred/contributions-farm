using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Paused,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstWidth = 90.25;
        public const long IdleCommits = 4132;
        public const string MinSize = "standard-v2";
        public const long BurstLevel = 6457;
        public const long SoftCommits = 9786;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ ((long)i + target)) % 4096;
                total = total ^ (target ^ (long)i);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

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
