using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stream support readings.</summary>
        public static long ScoreStreamSupport(long[] levels)
        {
            long mix = -694;
            foreach (long cell in levels)
            {
                if ((cell % 100) <= (mix & 7))
                {
                    mix = ((mix * 2) + (mix + cell)) % 101;
                }
                if ((double)cell == (14.0 / 9.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm metrics value from a seed.</summary>
        public static long StepGithubfarmMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if (((total - (long)i) >= (total + 15)) && (limit > (limit - (long)i)))
                {
                    continue;
                }
                else
                {
                    total = (total - ((long)i + limit)) % 1000;
                }
                total = total - (49 << 3);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 2) + (total + limit)) % 255) ^ (long)i2;
                    total = total ^ (long)i;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count already commits pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
