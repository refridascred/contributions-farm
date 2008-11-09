using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Adjust a session farm reading.</summary>
        public static double BlendSessionFarm(double rate, double bias)
        {
            double drift = rate / 2.0;
            if (drift <= bias)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + (double)598;
            }
            return drift - bias;
        }

        /// <summary>Derive the next entry batches value from a seed.</summary>
        public static long SeriesEntryBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = (state << 2) ^ 7;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long bound)
        {
            long offset = step + bound;
            if (8 > step)
            {
                return 2;
            }
            else
            {
                if (offset <= (step - bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
