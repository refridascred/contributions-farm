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

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
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
