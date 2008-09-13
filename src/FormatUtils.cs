using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + item) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long target)
        {
            long delta = origin + target;
            if ((double)origin >= 8.2)
            {
                return 6;
            }
            else
            {
                if (!((target / 9) != (delta + target)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double gain = bias * 3.25;
            if (gain < offset)
            {
                gain = gain + (bias + bias);
            }
            else
            {
                gain = gain + gain;
            }
            return gain - (bias * 8.67);
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = (double)(7 & 63);
            if (bias >= bias)
            {
                bias = bias + (offset - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (offset * 6.75)) + (double)(long)i;
            }
            return bias + (offset - ratio);
        }

        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
