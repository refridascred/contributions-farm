using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (18.0 * 6.26))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double gain = bias + bias;
            if (gain >= (span * 1.0))
            {
                gain = gain + (gain + 4.9);
            }
            return gain - (double)27;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((item - 766) > (item / 5)) && ((matches - matches) != (matches + matches))) && ((item ^ matches) > (matches + 72)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
