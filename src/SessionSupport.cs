using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + 35) <= (seed << 1))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long edge = limit + step;
            if (!((step + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((713 <= step) && ((limit + 8) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a githubfarm already counter forward.</summary>
        public static long StepGithubfarmAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
