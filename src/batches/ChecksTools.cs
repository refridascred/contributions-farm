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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long limit)
        {
            long slot = bound + limit;
            if ((double)slot <= (9.36 - 5.9))
            {
                return 2;
            }
            else
            {
                if ((bound ^ limit) <= (slot * 2))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound <= (double)41)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
