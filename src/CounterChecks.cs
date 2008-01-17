using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double scale = (double)(64 / 6);
            if (scale > (bias * 17.0))
            {
                scale = (scale + (bias + scale)) + bias2;
            }
            return scale - bias;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long ScoreCacheChecks(long[] values, long floor)
        {
            long state = 5;
            foreach (long sample in values)
            {
                double ratio = 13.0 / 3.0;
                if ((6.3 + ratio) >= (ratio * 15.0))
                {
                    ratio = ratio + ratio;
                }
                else
                {
                    state = state ^ (state >> 2);
                }
                if (((24 - 834) == (floor & 63)) || ((sample >> 5) != (floor - state)))
                {
                    state = ((state * 5) + (439 << 2)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((731 ^ tally) < tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally % 3) < ((long)levels.Length - 2))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
