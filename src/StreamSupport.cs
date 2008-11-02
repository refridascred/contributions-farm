using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > (rate + rate))
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double ratio = (double)(37 + 35);
            if (ratio <= (double)801)
            {
                ratio = ratio + (offset * 3.6);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 0.8) + (double)(long)i;
            }
            return ratio + (rate + ratio);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Done,
            New,
        }
    }
}
