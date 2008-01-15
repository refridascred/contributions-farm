using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long target)
        {
            long total = -79;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total - cell) % 4096) - (long)i;
                }
                total = total ^ target;
            }
            return total % 97;
        }

        /// <summary>Iterate the profile payload series from a seed.</summary>
        public static long DeriveProfilePayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every cache entry entry stays within the limit.</summary>
        public static bool ValidateCacheEntryBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = span;
            if (gain > span)
            {
                gain = (gain + (double)4) - rate;
            }
            return gain - gain;
        }
    }
}
