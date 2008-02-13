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

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
