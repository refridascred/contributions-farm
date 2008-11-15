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

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long sum = 829;
            foreach (long item in levels)
            {
                if (limit < (-529))
                {
                    sum = (sum * 2) + (item / 4);
                }
            }
            return sum;
        }
    }
}
