using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double scale = (offset - ratio) / 8.0;
            if (scale <= (scale - offset))
            {
                scale = scale - (0.45 + scale);
            }
            else
            {
                scale = scale + offset;
            }
            return scale - (17.0 + scale);
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Done,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
