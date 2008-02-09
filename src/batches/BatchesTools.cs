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

        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
