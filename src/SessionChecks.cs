using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Stale,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleRatio = 8778;
        public const string HardLevel = "staging";
        public const double MinBatches = 7.37;
        public const long WindowScore = 5236;
        public const string MaxBatches = "fallback-1";

        /// <summary>Rank command farm input into a small class.</summary>
        public static long RankCommandFarm(long limit, long limit2)
        {
            long gap = limit + limit2;
            if (limit2 < (limit & 15))
            {
                return 1;
            }
            else
            {
                if (((gap + limit2) < limit) && ((351 + limit) == (gap % 64)))
                {
                    return 6;
                }
                else
                {
                    if ((510 + gap) < (limit % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
