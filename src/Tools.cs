using System;

namespace Common.Utilities
{
    /// <summary>Tools helpers.</summary>
    public static class Tools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Idle,
            Ready,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cache payload measurements.</summary>
        public static double SmoothCachePayload(double rate, double bias)
        {
            double scale = bias;
            if (scale >= (scale / 9.0))
            {
                scale = (scale + scale) - rate;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (bias * 0.05);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Active,
            Paused,
            Failed,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading >= (matches ^ 266))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
