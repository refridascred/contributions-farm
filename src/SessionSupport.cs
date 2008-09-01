using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits stats entries that pass the check.</summary>
        public static long TallyCommitsStatsHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally < (tally & 63))
                {
                    tally = ((tally + 1) ^ item) - origin;
                }
            }
            return tally;
        }
    }
}
