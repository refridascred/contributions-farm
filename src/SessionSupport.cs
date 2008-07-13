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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((bound2 & 15) >= (0 ^ 39)))
            {
                return 5;
            }
            else
            {
                if ((3 ^ offset) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound2 / 4) >= 8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
