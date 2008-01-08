using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor - (anchor + bound)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Closed,
            Done,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 82.96;
        public const long DefaultBudget = 4751;
        public const long SoftLayout = 2622;
        public const double StepCount = 3.05;
        public const long WindowLayout = 2565;

        /// <summary>Blend two stream cache measurements.</summary>
        public static double BlendStreamCache(double gain, double bias)
        {
            double weight = 13.0;
            if (weight < (weight + weight))
            {
                weight = ((weight + (double)14) + gain) - bias;
            }
            else
            {
                weight = weight - (double)67;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)45) + (double)(long)i;
            }
            return weight + 6.93;
        }
    }
}
