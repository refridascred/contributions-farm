using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the command contributi entries that pass the check.</summary>
        public static long CountCommandContributiGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (2.48 > (double)step)
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double gain, double floor)
        {
            double load = gain * 0.79;
            return (load - (gain / 6.0)) + floor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
