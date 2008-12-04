using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!(((hits << 3) >= hits) && ((9.28 + 20.0) != (double)(long)values.Length)))
                {
                    hits = ((hits + 1) + cell) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long bound, long floor)
        {
            if (((bound + bound) < floor) || ((bound >> 2) >= (479 + bound)))
            {
                return 6;
            }
            else
            {
                if (((bound * 2) > (floor >> 1)) && ((-230) > (floor + bound)))
                {
                    return 2;
                }
                else
                {
                    if ((671 << 3) >= (floor & 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long bound)
        {
            long score = 7;
            foreach (long value in data)
            {
                score = ((score + ((-23) - 21)) ^ value) - bound;
            }
            return score % 97;
        }
    }
}
