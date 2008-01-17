using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length < (321 % 7))
                {
                    tally = ((tally + 1) - reading) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer window series from a seed.</summary>
        public static long SeriesBufferWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc << 3) ^ (bound + bound);
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
