using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate checks notes samples.</summary>
        public static long FoldChecksNotes(long[] samples, long bound)
        {
            long score = -48;
            foreach (long cell in samples)
            {
                score = (score * 3) + (bound - (-732));
                if (((925 & 31) >= (score / 4)) && ((6 - bound) >= score))
                {
                    score = ((score << 2) ^ ((long)samples.Length ^ cell)) % 97;
                }
                if ((bound - score) <= cell)
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score ^ 6) % 255;
            }
            return score;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long limit)
        {
            if ((double)step <= 9.1)
            {
                return 7;
            }
            else
            {
                if ((limit - step) >= limit)
                {
                    return 3;
                }
                else
                {
                    if ((9.0 > (double)step) && (limit > (step - limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((step % 7) < (limit / 2)) || ((limit >> 1) <= (34 + limit)))
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
        }

        /// <summary>Look up the position of a githubfarm format sample.</summary>
        public static long FindGithubfarmFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long limit)
        {
            long score = 148;
            foreach (long reading in data)
            {
                if ((4.96 / 4.0) < (double)score)
                {
                    score = ((score * 3) + reading) - limit;
                }
            }
            return score % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftInterval = 3771;
        public const long LimitAlready = 8545;
        public const double BurstInterval = 72.38;

        /// <summary>Count notes metric pairs that satisfy a relation.</summary>
        public static long MatchNotesMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
