using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((step ^ 944) > matches) && (((matches % 16) == (matches + sample)) || ((double)matches > (9.61 * 12.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((-89) < seed)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
