using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 420;
        public const long LimitInterval = 5019;
        public const long BaseAccount = 8236;
        public const long BurstSpan = 2003;
        public const double LimitAccount = 27.06;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (5.0 - gain);
        }
    }
}
