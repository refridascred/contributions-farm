using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Total { get; set; }
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a schema filter figure with a bias.</summary>
        public static double SmoothSchemaFilter(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (floor / 8.0))
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 - 2.39;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double bias = (weight * 5.0) * 11.0;
            if (bias <= bias)
            {
                bias = (bias + 0.97) + floor;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + (weight / 2.0);
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Draft,
            Active,
            Synced,
        }
    }
}
