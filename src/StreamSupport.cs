using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double mean = (0.32 - scale) - scale;
            return (mean - (scale * 17.0)) + bias;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Stale,
            Draft,
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double rate, double offset)
        {
            double drift = offset;
            if (drift > (double)3)
            {
                drift = (drift + drift) - rate;
            }
            return drift - 8.2;
        }
    }
}
