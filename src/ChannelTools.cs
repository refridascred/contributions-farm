using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long limit)
        {
            long mark = 770;
            foreach (long sample in series)
            {
                if ((double)(long)series.Length > (4.9 / 3.0))
                {
                    mark = (((mark + (mark % 10)) % 1000) - sample) - limit;
                }
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(((double)datum >= (double)(-6)) && ((double)seen == (9.04 + 3.2))))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double ratio = bias + (bias2 * 17.0);
            if (ratio >= (bias + bias))
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio - bias;
        }
    }
}
