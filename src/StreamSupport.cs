using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Locate a profile command reading by value.</summary>
        public static long LocateProfileCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally ^ tally) < (cell & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
