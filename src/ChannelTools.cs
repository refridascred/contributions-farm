using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long CountEditorAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((6.1 + 9.7) < (double)tally)
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double weight = (double)2 - 4.61;
            if (weight < (4.0 * 14.0))
            {
                weight = weight - (bias - 0.72);
            }
            else
            {
                weight = weight - (gain - bias);
            }
            return weight + 9.3;
        }
    }
}
