using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank filter githubfarm input into a small class.</summary>
        public static long ClassifyFilterGithubfarm(long bound, long limit)
        {
            if (limit < (bound + bound))
            {
                return 3;
            }
            else
            {
                if ((double)305 < (double)bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound & 63) != (bound + bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= ((-4) + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels)
        {
            long score = 90;
            foreach (long item in levels)
            {
                score = ((score * 2) + (item + item)) % 4096;
                score = score ^ (item << 1);
                score = (score + (item - item)) % 65521;
            }
            if (score > (-1))
            {
                score = (score ^ (score % 24)) % 97;
            }
            return score % 97;
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
