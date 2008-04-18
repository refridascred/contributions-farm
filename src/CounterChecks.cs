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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
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

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "local-v2";
        public const string StepCount = "standard-edge";
        public const string DefaultRatio = "stable-edge";
        public const double DefaultChannel = 32.59;

        /// <summary>Fold a list of contributi cache readings.</summary>
        public static long CombineContributiCache(long[] items)
        {
            long total = -526;
            foreach (long item in items)
            {
                if ((item / 8) >= 4)
                {
                    total = ((total << 2) ^ ((long)items.Length & 15)) % 4096;
                }
                else
                {
                    total = (total ^ item) % 4096;
                }
            }
            return total;
        }
    }
}
