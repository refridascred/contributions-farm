using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((7.29 / 7.0) >= (double)(long)i)
                {
                    state = state ^ state;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                total = (((total - (total / 2)) % 97) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Validate payload farm readings against a bound.</summary>
        public static bool ValidatePayloadFarmLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
