using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cluster notes reading.</summary>
        public static double ScaleClusterNotes(double rate, double span)
        {
            double scale = span - (rate - span);
            if (scale > scale)
            {
                scale = scale + (scale * 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (span - 4.02)) - (double)(long)i;
            }
            return scale - 20.0;
        }

        /// <summary>Count the session route entries that pass the check.</summary>
        public static long CountSessionRouteHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value & 63) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchRatio = 37.25;
        public const long IdleDepth = 5756;
        public const long CacheRatio = 3406;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
