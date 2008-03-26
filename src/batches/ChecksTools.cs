using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples, long limit)
        {
            long anchor = 103;
            foreach (long entry in samples)
            {
                if (18.0 < (double)anchor)
                {
                    anchor = (anchor + (anchor << 3)) % 97;
                }
                else
                {
                    anchor = (anchor << 3) ^ (limit ^ limit);
                }
                if ((anchor * 5) >= (entry >> 3))
                {
                    break;
                }
            }
            if (anchor > (-20))
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double mean = ratio - (double)61;
            if (mean <= (9.0 - mean))
            {
                mean = mean - (bias + 4.9);
            }
            else
            {
                mean = mean - (bias + mean);
            }
            return mean - (double)8;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell - matches) >= (69 / 4)) && ((cell - cell) > (matches >> 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
