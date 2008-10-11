using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Locked,
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long offset2)
        {
            long bound = offset + offset2;
            if ((offset2 & 63) >= (bound + 3))
            {
                return 6;
            }
            else
            {
                if ((offset2 / 7) <= (offset << 2))
                {
                    return 3;
                }
                else
                {
                    if (bound <= (offset & 15))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
