using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((cell * 4) > (tally ^ cell)) && ((tally + tally) != (7 + cell))) || ((tally % 24) < (cell + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long bound, long bound2)
        {
            if ((0.99 / 7.0) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((7.3 / 5.0) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if ((double)bound2 < 4.17)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
