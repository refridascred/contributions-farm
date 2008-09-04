using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a layout counter figure with a bias.</summary>
        public static double AdjustLayoutCounter(double weight, double span)
        {
            double mean = (weight - weight) - (span * 10.0);
            if (mean <= weight)
            {
                mean = mean + (weight * 19.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)2;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
