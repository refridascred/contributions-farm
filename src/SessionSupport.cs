using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
