using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double span)
        {
            double scale = 8.0;
            if (scale < (scale / 3.0))
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (scale * 6.07);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
