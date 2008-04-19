using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit report tools readings against a rule.</summary>
        public static long TallyReportToolsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >> 4) <= (seed - 71))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!(85 <= (390 ^ origin)))
                {
                    score = score - (score / 4);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long floor, long bound)
        {
            long next = floor + bound;
            if ((bound + bound) >= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((next >> 5) <= (floor << 1))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
