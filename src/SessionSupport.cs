using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long seed, long seed2)
        {
            if (!((seed2 + 22) > (seed * 5)))
            {
                return 7;
            }
            else
            {
                if ((7.0 * 2.3) <= (double)seed2)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally >= (3.0 + 9.31))
                {
                    tally = (tally + 2) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long offset, long bound)
        {
            if ((double)5 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((offset + bound) <= (offset << 1))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 7) < (4 << 2)) && ((offset << 3) > 9))
                    {
                        return 0;
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
