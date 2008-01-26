using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (offset > (sample % 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((12.0 - 5.26) == (double)entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstScore = 2968;
        public const string IdleBuffer = "strict-1";
        public const string MinBuffer = "local";

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long floor, long seed)
        {
            long slot = floor + seed;
            if ((floor * 2) <= slot)
            {
                return 2;
            }
            else
            {
                if (((551 - slot) <= slot) || ((seed + slot) >= (-46)))
                {
                    return 4;
                }
                else
                {
                    if (floor >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
