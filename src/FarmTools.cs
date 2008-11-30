using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Paused,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 1.2)
            {
                drift = drift - (drift + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)6) + (double)(long)i;
            }
            return drift + (bias - drift);
        }
    }
}
