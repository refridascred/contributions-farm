using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Mode { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count schema order pairs that satisfy a relation.</summary>
        public static long MatchSchemaOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Owner { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }
    }
}
