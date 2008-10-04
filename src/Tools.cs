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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
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

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Failed,
            Paused,
            New,
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
