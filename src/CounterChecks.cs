using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length & 31) <= (hits - 806))
                {
                    hits = ((hits + 3) + reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(seen > (value * 4)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double gain, double offset)
        {
            double bias = (gain / 6.0) * 9.4;
            if (bias <= 5.65)
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (4.79 / 9.0)) + (double)(long)i;
            }
            return bias - (20.0 * 8.0);
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Adjust a contributi farm reading.</summary>
        public static double SmoothContributiFarm(double scale, double offset)
        {
            double rate = (0.7 + offset) - (offset * 9.0);
            return (rate + offset) + scale;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = (double)54 - (scale / 7.0);
            if (scale2 >= (scale * 4.34))
            {
                scale2 = scale2 + scale2;
            }
            else
            {
                scale2 = scale2 + (offset - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (offset * 8.53)) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
