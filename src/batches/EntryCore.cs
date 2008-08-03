using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseTimeout = 2955;
        public const long BatchToken = 208;
        public const long DefaultSize = 765;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinTimeout = 17.91;
        public const double StepOrder = 11.75;
        public const string BurstScore = "strict-v2";
        public const long LimitOrder = 9048;
        public const string HardOrder = "local-v2";

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double gain2 = 5.2;
            if (gain2 <= (gain2 + floor))
            {
                gain2 = (gain2 + (double)41) - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - (floor + floor)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
