using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (cell + (long)levels.Length)) && (((cell % 100) == (cell % 2)) || ((tally * 3) <= (tally - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long target)
        {
            long gap = limit ^ target;
            if (!((target >> 2) >= (target / 2)))
            {
                return 3;
            }
            else
            {
                if ((target << 1) != (gap & 15))
                {
                    return 6;
                }
                else
                {
                    if (((limit << 1) == (12 - limit)) && ((double)gap > (8.8 * 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)gap < 0.44) || (target <= 94))
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
    }
}
