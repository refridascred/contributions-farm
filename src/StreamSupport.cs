using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double scale = (double)((-8) - 4);
            if (scale < scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (17.0 + scale)) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
