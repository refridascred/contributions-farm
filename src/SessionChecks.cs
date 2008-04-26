using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double drift = 3.5 - (rate * 4.6);
            if (drift > (drift + drift))
            {
                drift = (drift + (drift - rate)) - floor;
            }
            else
            {
                drift = drift + (double)88;
            }
            return drift + drift;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
