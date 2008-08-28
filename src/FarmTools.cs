using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double drift = (double)((-8) - 840);
            if (drift <= span)
            {
                drift = (drift + 4.0) + scale;
            }
            return drift - 16.0;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                long diff = (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    diff = ((diff << 3) ^ (state - 182)) % 4096;
                    diff = diff + (long)i2;
                }
                state = state + (diff * 2);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)datum >= 12.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
