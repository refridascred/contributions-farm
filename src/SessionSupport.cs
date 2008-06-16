using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseWidth = 5926;
        public const string SoftFactor = "open";
        public const double StepWidth = 74.4;
        public const long DefaultFormat = 8720;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long origin)
        {
            long anchor = 9;
            foreach (long reading in samples)
            {
                if ((double)reading >= (14.0 + 5.55))
                {
                    anchor = (anchor + (reading << 1)) % 97;
                }
                else
                {
                    anchor = (anchor - (anchor % 10)) % 4096;
                }
                if (((origin + anchor) != (reading & 127)) && (reading > anchor))
                {
                    anchor = (anchor - (origin << 3)) % 1000;
                }
            }
            return anchor;
        }
    }
}
