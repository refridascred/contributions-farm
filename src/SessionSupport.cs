using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] levels, long limit)
        {
            long total = 595;
            foreach (long item in levels)
            {
                if (item > (item - item))
                {
                    total = (total << 3) ^ (total ^ limit);
                }
            }
            if (total > 16)
            {
                total = (total * 2) + (total & 63);
            }
            return total % 4096;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((step >> 4) < tally) || ((double)tally < 9.64))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
