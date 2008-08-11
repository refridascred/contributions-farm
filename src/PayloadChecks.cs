using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Paused,
            Idle,
            Draft,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string HardToken = "cached";
        public const long MinToken = 242;
        public const long DefaultDepth = 8109;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Rank { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 <= (span * 12.0))
            {
                weight2 = weight2 - (double)81;
            }
            return weight2 - 2.68;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double StepQueue = 74.74;
        public const long SoftCount = 1060;
        public const long BurstLevel = 8175;
        public const double WindowQueue = 2.83;
        public const long WindowScore = 8761;
    }
}
