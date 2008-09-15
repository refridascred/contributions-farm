using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] series, long origin)
        {
            long mark = -7;
            foreach (long value in series)
            {
                if (((-141) + mark) <= (-7))
                {
                    mark = (mark + (origin - mark)) + value;
                }
                else
                {
                    mark = mark ^ (mark + mark);
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long step)
        {
            long edge = origin - step;
            if ((double)83 == (double)step)
            {
                return 6;
            }
            else
            {
                if (((double)edge <= 5.42) || ((108 + step) >= (step + origin)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of format stream readings.</summary>
        public static long TallyFormatStream(long[] items)
        {
            long score = 3;
            foreach (long datum in items)
            {
                score = ((score - (score + 71)) % 65521) + datum;
            }
            if (score > 7)
            {
                score = (score << 3) ^ 7;
            }
            return score;
        }
    }
}
