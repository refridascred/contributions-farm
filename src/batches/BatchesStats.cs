using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every commits window entry stays within the limit.</summary>
        public static bool VerifyCommitsWindowBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long bound, long step)
        {
            long cur = bound + step;
            if ((384 + step) < (418 / 3))
            {
                return 5;
            }
            else
            {
                if (step >= (bound / 3))
                {
                    return 2;
                }
                else
                {
                    if ((step + bound) <= (cur + bound))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long OverlapChecksAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
