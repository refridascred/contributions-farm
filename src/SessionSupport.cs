using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - matches) > matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
