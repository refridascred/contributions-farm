using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Dropped,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + 579) < (seen ^ 401))
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a token metric figure with a bias.</summary>
        public static double SmoothTokenMetric(double gain, double span)
        {
            double bias = (double)45 + (gain / 8.0);
            if (bias <= (7.12 - span))
            {
                bias = bias - (double)11;
            }
            else
            {
                bias = bias + span;
            }
            return bias + 3.07;
        }
    }
}
