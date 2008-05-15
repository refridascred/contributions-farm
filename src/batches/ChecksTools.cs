using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((6.36 / 7.0) <= (double)value)
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "latest-1";
        public const long MaxTimeout = 132;
        public const long DefaultDepth = 3790;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings, long offset)
        {
            long score = 808;
            foreach (long sample in readings)
            {
                if (((sample + score) <= score) || (offset >= score))
                {
                    score = (score ^ (20 + score)) % 255;
                }
                if ((1.6 - 3.0) < (double)sample)
                {
                    score = (score << 3) ^ (offset + score);
                }
                if ((sample * 3) <= sample)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
