using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long seed)
        {
            if ((bound ^ seed) >= 67)
            {
                return 0;
            }
            else
            {
                if (bound > (426 >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((2 - bound) > ((-82) + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound - seed) >= (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings)
        {
            long acc = 498;
            foreach (long datum in readings)
            {
                if ((acc - datum) >= (datum + acc))
                {
                    acc = ((acc * 2) + (acc + acc)) % 101;
                }
            }
            if (acc > (-60))
            {
                acc = (acc + (acc + acc)) % 255;
            }
            return acc;
        }
    }
}
