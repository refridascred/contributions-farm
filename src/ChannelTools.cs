using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleWidth = "strict-edge";
        public const long WindowRecord = 8066;
        public const string RetryCount = "local-edge";
        public const string HardRecord = "stable-edge";
        public const string RetryRecord = "alpha";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double floor)
        {
            double weight = (double)(1 + (-261));
            if (weight >= weight)
            {
                weight = ((weight - (weight / 3.0)) - rate) + floor;
            }
            return weight + (double)278;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
