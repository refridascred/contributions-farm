using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ScaleFarm(double scale, double floor)
        {
            double drift = (double)((-13) - 43);
            if (drift <= (double)9)
            {
                drift = ((drift - drift) - scale) + floor;
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Closed,
            Queued,
            Draft,
        }
    }
}
