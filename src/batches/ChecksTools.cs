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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long target, long origin)
        {
            long delta = target + origin;
            if (!((1.1 / 8.0) >= (double)target))
            {
                return 1;
            }
            else
            {
                if ((delta >= (delta << 3)) || ((delta * 4) < 43))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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
