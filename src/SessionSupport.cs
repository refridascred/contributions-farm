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

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
