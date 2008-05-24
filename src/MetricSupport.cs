using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 4416;
        public const long MaxToken = 3464;
        public const double DefaultFactor = 79.16;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
