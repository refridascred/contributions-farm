using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits session readings against a rule.</summary>
        public static long TallyCommitsSessionOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + 453) < (hits + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long target, long bound)
        {
            long step = target + bound;
            if (((step & 127) <= (877 + step)) || (((-71) << 3) != (target - step)))
            {
                return 2;
            }
            else
            {
                if (((step * 3) > bound) || ((1.0 * 4.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((7 << 2) >= (bound + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
