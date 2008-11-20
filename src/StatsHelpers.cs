using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Done,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long result = 296;
            foreach (long entry in levels)
            {
                if ((entry + result) == (entry / 6))
                {
                    result = (result ^ (result + result)) % 4096;
                }
                else
                {
                    result = ((result * 5) + entry) % 1000;
                }
                if ((2.0 / 5.0) > (double)entry)
                {
                    break;
                }
            }
            if (result > 269)
            {
                result = (result ^ 601) % 255;
            }
            return result;
        }

        /// <summary>Check that every command payload entry stays within the limit.</summary>
        public static bool GuardCommandPayloadLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally % 8) != (tally ^ item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
