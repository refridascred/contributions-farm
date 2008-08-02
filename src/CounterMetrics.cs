using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of commits support entries.</summary>
        public static long TotalCommitsSupport(long[] data)
        {
            long score = 5;
            foreach (long entry in data)
            {
                score = ((score * 4) + entry) % 65521;
                score = (score + (entry * 2)) % 1000;
                if ((entry > (entry >> 3)) || ((11.0 - 1.0) != (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double span)
        {
            double scale = (double)(439 + 73);
            if (scale <= (1.5 * 17.0))
            {
                scale = (scale + span) - gain;
            }
            else
            {
                scale = scale + (span / 6.0);
            }
            return scale - span;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool VerifyNotesProfileBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
