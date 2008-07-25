using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a cache profile figure with a bias.</summary>
        public static double AdjustCacheProfile(double bias, double span)
        {
            double load = (3.2 - 9.0) + (span * 10.0);
            if (load < 2.0)
            {
                load = load + load;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)96) - (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 4) >= cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell * 4) < (seed + 180)) && !((806 + cell) > (seed + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
