using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (1.97 >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double floor)
        {
            double gain = (double)457 * 9.0;
            return ((gain - (1.12 * 5.1)) + weight) + floor;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }
    }
}
