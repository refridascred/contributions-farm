using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double SmoothAlreadyCounter(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - bias) - (double)(long)i;
            }
            return ratio - (weight - weight);
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long anchor = 962;
            foreach (long cell in readings)
            {
                if ((cell >= (62 >> 2)) && ((anchor ^ 2) > (anchor + cell)))
                {
                    anchor = (anchor - (floor >> 4)) % 97;
                }
            }
            if (anchor < 70)
            {
                anchor = (anchor + (anchor * 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
