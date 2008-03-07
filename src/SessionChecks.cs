using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
