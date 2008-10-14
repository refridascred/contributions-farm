using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-1";
        public const double MinSize = 47.19;
        public const long WindowSize = 1042;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] samples, long seed)
        {
            long anchor = 8;
            foreach (long reading in samples)
            {
                anchor = ((((anchor << 3) ^ (anchor >> 4)) % 1000) + reading) - seed;
            }
            return anchor;
        }
    }
}
