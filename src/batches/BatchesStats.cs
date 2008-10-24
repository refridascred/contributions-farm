using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double weight = ratio;
            return (weight - (4.6 / 2.0)) + bias;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((cell < (0 >> 4)) && ((double)tally < (10.0 / 3.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double scale, double offset)
        {
            double ratio = scale;
            if (ratio >= scale)
            {
                ratio = (ratio - (scale + scale)) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + (double)208;
        }
    }
}
