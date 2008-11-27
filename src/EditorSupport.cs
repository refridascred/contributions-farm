using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the metric profile entries that pass the check.</summary>
        public static long MeasureMetricProfileOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((matches * 2) < (84 >> 5)) && ((double)matches > (double)bound)))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double gain, double bias)
        {
            double bias2 = gain * 9.17;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (gain / 3.0)) + (double)(long)i) - bias;
            }
            return bias2 - (bias2 / 6.0);
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Audit editor context readings against a rule.</summary>
        public static long MeasureEditorContextHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell < (7.9 * 14.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cluster entry values into a single score.</summary>
        public static long TotalClusterEntry(long[] readings, long limit)
        {
            long sum = 643;
            foreach (long entry in readings)
            {
                sum = ((sum ^ ((long)readings.Length / 9)) % 1000) ^ entry;
            }
            if (sum < 67)
            {
                sum = sum ^ (limit ^ limit);
            }
            return sum % 65521;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 >= (double)979)
            {
                ratio2 = (ratio2 + (double)19) + ratio;
            }
            else
            {
                ratio2 = ratio2 + bias;
            }
            return ratio2 - ratio2;
        }
    }
}
