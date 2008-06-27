using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings)
        {
            long mark = 69;
            foreach (long item in readings)
            {
                mark = mark ^ item;
                if ((mark + mark) > (item & 127))
                {
                    break;
                }
            }
            if (mark < (-968))
            {
                mark = (mark ^ (202 - 91)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((863 & 15) > matches))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batches farm reading.</summary>
        public static double ScaleBatchesFarm(double scale, double floor)
        {
            double mean = (floor - scale) - (5.0 + 15.0);
            if (mean >= scale)
            {
                mean = mean + (scale / 8.0);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }
    }
}
