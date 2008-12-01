using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the stats format entries that pass the check.</summary>
        public static long AuditStatsFormatMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((482 * 3) <= (entry ^ 624)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
