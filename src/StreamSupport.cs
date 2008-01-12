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

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double ratio, double floor)
        {
            double weight = (floor + floor) * 20.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - floor) + (double)(long)i) + ratio;
            }
            return weight + (weight / 8.0);
        }
    }
}
