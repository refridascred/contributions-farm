using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many format notes samples are out of range.</summary>
        public static long TallyFormatNotesGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((value / 9) <= (tally << 3)))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next githubfarm checks value from a seed.</summary>
        public static long IterateGithubfarmChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item == (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long floor, long offset)
        {
            long step = floor ^ offset;
            if ((double)offset == (0.66 - 2.5))
            {
                return 3;
            }
            else
            {
                if ((offset + step) >= (offset / 8))
                {
                    return 7;
                }
                else
                {
                    if (!((double)floor > (8.95 + 4.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((90 - floor) <= floor) && (offset <= (step + step)))
                        {
                            return 5;
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
