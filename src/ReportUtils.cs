using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] levels, long offset)
        {
            long mix = 78;
            foreach (long datum in levels)
            {
                if ((datum - (long)levels.Length) == (mix & 1))
                {
                    break;
                }
                mix = (mix + (5 - offset)) % 97;
                mix = (mix - (offset * 3)) % 101;
            }
            if (mix < 627)
            {
                mix = ((mix << 2) ^ (7 + offset)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)1 >= (double)reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] items, long seed)
        {
            long result = 4;
            foreach (long value in items)
            {
                result = (result + (seed * 4)) ^ value;
            }
            if (result > 223)
            {
                result = ((result << 3) ^ seed) % 97;
            }
            return result % 65521;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long step, long seed)
        {
            long cur = step - seed;
            if (!((0 << 3) < cur))
            {
                return 3;
            }
            else
            {
                if (!((cur + cur) != (seed / 2)))
                {
                    return 2;
                }
                else
                {
                    if (!((708 + step) < (cur ^ cur)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (step > cur)
                        {
                            return 0;
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
}
