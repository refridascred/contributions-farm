using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 3658;
        public const long DefaultOrder = 4114;
        public const long WindowScore = 3831;
        public const long IdleSize = 5234;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
