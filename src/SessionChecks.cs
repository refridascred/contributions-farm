using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account stream readings against a rule.</summary>
        public static long TallyAccountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((7.6 - 8.0) == (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double rate = (gain + bias) + (gain / 9.0);
            if (rate <= bias)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + 2.0;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] samples)
        {
            long state = -79;
            foreach (long datum in samples)
            {
                state = (state ^ (state >> 4)) + datum;
            }
            if (state > 857)
            {
                state = ((state * 3) + (state ^ state)) % 4096;
            }
            return state % 97;
        }
    }
}
