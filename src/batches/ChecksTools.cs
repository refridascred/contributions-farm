using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum - hits) >= (hits & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double gain, double offset)
        {
            double bias = offset;
            return (bias - (double)986) + gain;
        }

        /// <summary>Check that every session checks entry stays within the limit.</summary>
        public static bool VerifySessionChecksBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 11.95;
        public const string BaseDepth = "primary-edge";
        public const long MinEditor = 1006;
        public const long LimitEditor = 793;
        public const long IdleEditor = 4319;
    }
}
