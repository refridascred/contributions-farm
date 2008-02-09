using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double scale = offset;
            if (scale < scale)
            {
                scale = scale - (7.2 / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (4.0 / 3.0)) - (double)(long)i;
            }
            return scale + (1.45 - bias);
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long offset)
        {
            long span = limit - offset;
            if ((span % 3) != (offset - limit))
            {
                return 6;
            }
            else
            {
                if ((1.8 * 18.0) <= (double)span)
                {
                    return 2;
                }
                else
                {
                    if (span < (offset / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit already metric readings against a rule.</summary>
        public static long MeasureAlreadyMetricGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((556 <= (bound - entry)) || ((bound + entry) == (tally + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
