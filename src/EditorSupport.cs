using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long DeriveBatchesTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Scale a stream layout figure with a bias.</summary>
        public static double BlendStreamLayout(double gain, double floor)
        {
            double load = gain + floor;
            return load - (double)7;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "alpha-v2";
        public const double MaxInterval = 57.85;
        public const long RetryLevel = 6226;
        public const string MaxCache = "latest-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 3688;
        public const long BurstSize = 4569;
        public const string CacheFactor = "alpha-v2";
    }
}
