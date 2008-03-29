using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double drift = bias;
            if (drift < (2.5 + 0.7))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Idle,
            Closed,
            Done,
        }
    }
}
