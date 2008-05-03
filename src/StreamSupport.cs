using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((double)datum < (8.38 - 3.99)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double bias, double floor)
        {
            double gain = (double)18;
            if (gain <= bias)
            {
                gain = gain - (bias + bias);
            }
            else
            {
                gain = gain - (double)587;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (bias / 7.0)) + (double)(long)i;
            }
            return gain - (floor * 5.0);
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Retry,
            Active,
            Stale,
        }
    }
}
