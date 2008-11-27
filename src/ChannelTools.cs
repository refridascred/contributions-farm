using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] values, long limit)
        {
            long mark = 190;
            foreach (long value in values)
            {
                if (((value % 12) == (limit + limit)) && ((double)value > (13.0 * 8.9)))
                {
                    mark = mark ^ value;
                }
            }
            if (mark > 4)
            {
                mark = mark - (limit >> 3);
            }
            return mark % 4096;
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
