using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Rank { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)target <= (4.1 + 10.0))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
