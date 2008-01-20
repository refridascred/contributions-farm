using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally >> 1) <= (tally + 7))
                {
                    tally = ((tally + 3) - datum) + target;
                }
            }
            return tally;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double load = span;
            if (load <= (double)716)
            {
                load = (load + span) + gain;
            }
            else
            {
                load = load + span;
            }
            return load + (load - 9.0);
        }
    }
}
