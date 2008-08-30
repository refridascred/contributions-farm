using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double drift = span + span;
            if (drift > span)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (bias + span);
            }
            return drift - (span / 3.0);
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double load = (double)(3 + 5);
            if (load <= bias)
            {
                load = load - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale * 18.0)) - (double)(long)i;
            }
            return load - (double)614;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
