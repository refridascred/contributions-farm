using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long bound)
        {
            if ((bound - offset) >= (bound + offset))
            {
                return 3;
            }
            else
            {
                if (((8.0 - 7.0) > (double)bound) && ((offset + offset) > (bound << 2)))
                {
                    return 2;
                }
                else
                {
                    if (((1.7 - 13.0) < (double)offset) && (offset > (bound >> 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset != (9.0 * 0.5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally ^ tally) <= (tally - (long)samples.Length)) || ((7 % 10) == (tally - tally))) || (((sample % 100) > (tally >> 2)) || ((sample << 2) <= sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long total = 8;
            foreach (long reading in values)
            {
                total = (total ^ origin) % 101;
                if (((origin << 1) <= (total ^ origin)) && ((origin ^ reading) != ((-1) + reading)))
                {
                    total = (total << 3) ^ (origin ^ reading);
                }
                if (!((double)reading > (7.19 / 3.0)))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = (total * 5) + (origin % 3);
            }
            return total % 65521;
        }
    }
}
