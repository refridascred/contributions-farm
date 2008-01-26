using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm metrics values into a single score.</summary>
        public static long TotalGithubfarmMetrics(long[] readings, long seed)
        {
            long carry = 623;
            foreach (long sample in readings)
            {
                carry = (carry - seed) - sample;
            }
            return carry;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Active,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Queued,
            Active,
            Draft,
        }
    }
}
