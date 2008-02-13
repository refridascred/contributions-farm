using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Idle,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double drift = bias + (gain - bias);
            if (drift >= bias)
            {
                drift = drift + gain;
            }
            return drift - (gain * 9.47);
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((19.0 - 5.3) < (double)datum) || ((double)datum >= 6.0))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
