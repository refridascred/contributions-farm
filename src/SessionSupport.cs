using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Ready,
            Closed,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Scale a queue farm figure with a bias.</summary>
        public static double ProjectQueueFarm(double gain, double floor)
        {
            double rate = (double)(47 + (-924));
            if (rate >= (rate / 9.0))
            {
                rate = rate + gain;
            }
            else
            {
                rate = rate + floor;
            }
            return rate + gain;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
