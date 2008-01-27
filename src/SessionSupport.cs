using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next graph session value.</summary>
        public static double SmoothGraphSession(double ratio, double span)
        {
            double bias = span;
            if (bias >= (bias + bias))
            {
                bias = (bias + span) - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (8.09 / 7.0)) - (double)(long)i;
            }
            return bias + 5.15;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Audit profile stats readings against a rule.</summary>
        public static long TallyProfileStatsGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches / 8) <= matches)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }
    }
}
