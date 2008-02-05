using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double bias)
        {
            double ratio = 5.0;
            return ((ratio - 2.2) + rate) + bias;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] levels)
        {
            long state = 56;
            foreach (long entry in levels)
            {
                if (entry <= (state - entry))
                {
                    state = (state << 3) ^ (state / 5);
                }
            }
            if (state < 969)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
