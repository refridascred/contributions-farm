using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of counter entry readings.</summary>
        public static long PairCounterEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the already counter series from a seed.</summary>
        public static long StepAlreadyCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = anchor ^ (origin - (long)i2);
                }
                if (!(anchor > ((long)i - origin)))
                {
                    anchor = ((anchor * 2) + (origin ^ origin)) % 1000;
                }
                anchor = ((anchor * 3) + (origin - origin)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            New,
            Closed,
            Active,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double drift = 20.0;
            if (drift < (bias * 9.33))
            {
                drift = drift + gain;
            }
            else
            {
                drift = drift - (15.0 / 4.0);
            }
            return drift + drift;
        }
    }
}
