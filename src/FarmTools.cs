using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowFactor = "standard-edge";
        public const string BurstBudget = "standard";
        public const long SoftLevel = 898;
        public const string MaxCluster = "latest-edge";
        public const string MinLevel = "latest-edge";

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Token { get; set; }
        }
    }
}
