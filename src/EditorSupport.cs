using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 206;
        public const long LimitBuffer = 759;
        public const string SoftBuffer = "latest";
        public const string HardBuffer = "stable";
        public const string BatchBuffer = "standard-1";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (2 >= (sample % 16))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches & 255) > cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
