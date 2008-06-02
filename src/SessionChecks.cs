using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long seed)
        {
            if (6.2 > (double)offset)
            {
                return 0;
            }
            else
            {
                if (offset < (3 * 5))
                {
                    return 4;
                }
                else
                {
                    if (((68 - offset) != (341 * 5)) && ((seed >> 1) >= seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((3.3 / 6.0) < (double)seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long state = -78;
            foreach (long entry in values)
            {
                if (14 <= state)
                {
                    state = (state << 3) ^ (entry << 1);
                }
            }
            return state;
        }
    }
}
