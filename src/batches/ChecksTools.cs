using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool CheckGraphBatchBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 6110;
        public const double BaseSize = 46.44;
        public const long BatchRoute = 3656;

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "local-edge";
        public const string LimitOrder = "standard";
        public const double RetryBudget = 60.9;
    }
}
