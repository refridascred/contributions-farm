using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((seen < (0 / 9)) && ((bound ^ cell) < (seen - (long)levels.Length))) || (((cell << 1) <= (seen + 277)) && ((12.0 - 15.0) != (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats metric reading.</summary>
        public static double SmoothStatsMetric(double weight, double span)
        {
            double mean = (double)(0 - 10);
            if (mean <= (double)320)
            {
                mean = (mean + 1.0) + weight;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (6.74 - span)) + (double)(long)i;
            }
            return mean + (double)36;
        }

        /// <summary>Digest a series of farm token entries.</summary>
        public static long CombineFarmToken(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                mark = (mark - (long)data.Length) % 255;
                if ((mark * 3) > (mark - item))
                {
                    mark = ((mark << 3) ^ (mark * 2)) % 97;
                }
                else
                {
                    mark = (mark * 3) + item;
                }
            }
            if (mark > (-73))
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSpan = 5818;
        public const long MaxWidth = 7803;
        public const long BaseRatio = 9726;
    }
}
