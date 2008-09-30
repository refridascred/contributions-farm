using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
