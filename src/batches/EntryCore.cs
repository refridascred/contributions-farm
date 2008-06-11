using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine queue counter values into a single score.</summary>
        public static long TotalQueueCounter(long[] values, long target)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if (((9.99 / 8.0) == (double)target) || ((target - entry) <= carry))
                {
                    carry = (carry * 5) + (1 - carry);
                }
                if ((entry & 31) == (carry % 7))
                {
                    carry = carry ^ (target - target);
                }
            }
            return carry;
        }

        /// <summary>Locate a githubfarm editor reading by value.</summary>
        public static long FindGithubfarmEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long MinEntry = 6915;
        public const double RetryDepth = 62.92;
        public const long CacheEntry = 3217;
        public const double BurstEntry = 80.65;
    }
}
