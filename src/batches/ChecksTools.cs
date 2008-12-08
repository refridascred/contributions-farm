using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit report batches readings against a rule.</summary>
        public static long MeasureReportBatchesMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((double)count > (double)floor))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 > (double)9)
            {
                gain2 = gain2 + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = gain2 + (double)(long)i;
            }
            return gain2 + (19.0 - 3.3);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 3551;
        public const string CacheCounter = "alpha";
        public const double IdleSpan = 76.04;
    }
}
