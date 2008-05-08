using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double drift = bias;
            if (drift >= (double)208)
            {
                drift = (drift + drift) + scale;
            }
            return drift - bias;
        }
    }
}
