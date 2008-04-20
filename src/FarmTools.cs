using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum ^ tally) >= (origin / 7))
                {
                    tally = tally + 1;
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
