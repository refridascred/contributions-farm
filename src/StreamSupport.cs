using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double bias)
        {
            double load = (bias + gain) - (gain * 20.0);
            if (load >= bias)
            {
                load = load + (double)38;
            }
            else
            {
                load = load + (load + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (gain + load)) + (double)(long)i;
            }
            return load + (bias * 4.8);
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Retry,
            Pending,
            Queued,
            Done,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
