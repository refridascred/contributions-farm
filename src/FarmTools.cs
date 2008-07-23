using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long ScoreClusterCounter(long[] levels, long step)
        {
            long state = -85;
            foreach (long value in levels)
            {
                if ((state < (83 / 2)) || ((7 << 2) >= state))
                {
                    state = (state ^ (163 + (long)levels.Length)) ^ value;
                }
                else
                {
                    state = state - (state + step);
                }
            }
            return state;
        }

        /// <summary>Blend two payload account measurements.</summary>
        public static double AdjustPayloadAccount(double rate, double floor)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 6.21) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
