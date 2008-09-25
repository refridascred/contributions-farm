using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long bound)
        {
            long anchor = 206;
            foreach (long datum in levels)
            {
                anchor = ((anchor << 3) ^ (datum & 31)) % 4096;
                if ((datum << 3) >= (bound % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 6422;
        public const double StepQueue = 0.86;
        public const double BaseQueue = 21.97;
        public const long RetryRatio = 7551;

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double span)
        {
            double bias = (double)(69 * 3);
            if (bias > (double)290)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - gain;
            }
            return bias - span;
        }
    }
}
