using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double floor)
        {
            double rate = gain - (double)984;
            return rate - (floor - rate);
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Count the counter token entries that pass the check.</summary>
        public static long AuditCounterTokenGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (739 >= seen)
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
