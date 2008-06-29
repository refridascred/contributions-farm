using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double weight, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = ratio - (weight + 2.95);
            }
            return ratio - (double)733;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum & 3) < datum) || ((datum % 7) >= (datum + datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long seed)
        {
            if (((seed - seed) == (seed * 2)) || ((7.9 - 15.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if ((4 + seed) < 6)
                {
                    return 8;
                }
                else
                {
                    if ((3.5 - 3.68) >= (15.0 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
