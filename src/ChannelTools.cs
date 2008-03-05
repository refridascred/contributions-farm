using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((double)score > (6.2 - 3.65))
                {
                    score = ((score * 5) + (score % 24)) % 1000;
                }
                score = score + (origin * 2);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Look up the position of a githubfarm report sample.</summary>
        public static long FindGithubfarmReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
