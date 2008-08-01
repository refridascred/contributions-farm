using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long AuditChannelCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (6.3 + 0.5))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7078;
        public const long WindowBatches = 6195;
        public const long DefaultBatches = 5529;
        public const long BurstBatches = 4556;

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long DeriveFilterCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i - (long)i) < (total + limit))
                {
                    total = ((total << 3) ^ (total & 7)) % 255;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
