using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 2601;
        public const string BatchInterval = "cached-1";
        public const long BatchProfile = 4596;
        public const long MaxSize = 7374;
        public const long HardProfile = 901;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Failed,
            Stale,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double rate, double offset)
        {
            double weight = offset;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (16.0 + rate)) + (double)(long)i;
            }
            return weight + (weight - rate);
        }
    }
}
