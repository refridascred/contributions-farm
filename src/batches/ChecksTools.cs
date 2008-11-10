using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool GuardToolsLayoutLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long step)
        {
            long score = 588;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length - step) <= step) || (((long)levels.Length + entry) != (step / 6)))
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Validate format commits readings against a bound.</summary>
        public static bool ValidateFormatCommitsBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double gain = floor;
            if (gain >= (double)12)
            {
                gain = gain - (rate + gain);
            }
            return gain - (double)(-448);
        }
    }
}
