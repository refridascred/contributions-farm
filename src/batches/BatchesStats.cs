using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double ratio, double offset)
        {
            double scale = (offset - ratio) - offset;
            if (scale <= (double)58)
            {
                scale = scale + (ratio / 2.0);
            }
            else
            {
                scale = scale + (scale - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - 2.2) + (double)(long)i;
            }
            return scale + 0.63;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((8.0 + 7.71) <= (double)matches) && ((value * 3) <= matches))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
