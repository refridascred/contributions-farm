using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long result = 460;
            foreach (long entry in readings)
            {
                if ((225 + result) < (result >> 3))
                {
                    result = result ^ entry;
                }
                else
                {
                    result = (result - result) % 1000;
                }
            }
            if (result < 85)
            {
                result = (result - (result / 4)) % 101;
            }
            return result;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long seed)
        {
            if ((8.0 * 6.28) == (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed / 9) >= (seed - seed))
                {
                    return 7;
                }
                else
                {
                    if (!((floor - seed) <= (seed - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster filter value from a seed.</summary>
        public static long IterateClusterFilter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long result = 266;
            foreach (long reading in readings)
            {
                if ((reading + result) < (result + reading))
                {
                    result = ((result * 4) + (result % 97)) % 97;
                }
            }
            return result;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] series, long offset)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (!(offset >= (score + score)))
                {
                    score = (score - (315 << 1)) ^ cell;
                }
            }
            if (score < 95)
            {
                score = (score * 4) + (offset + score);
            }
            return score;
        }
    }
}
