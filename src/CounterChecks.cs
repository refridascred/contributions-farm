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

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long SortBatchTools(long step, long seed)
        {
            if ((seed > 360) || (step >= 99))
            {
                return 7;
            }
            else
            {
                if (((double)step > (double)seed) || ((step << 1) > (seed + (-9))))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double bias, double floor)
        {
            double scale = bias;
            if (scale <= (6.5 - scale))
            {
                scale = (scale - (7.3 * 6.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale + (6.5 * 18.0);
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
