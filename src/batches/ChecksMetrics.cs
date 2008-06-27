using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepFactor = 8666;
        public const string IdleSchema = "stable-1";
        public const long SoftSchema = 2114;

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double bias, double span)
        {
            double scale = span;
            return (scale - scale) + bias;
        }

        /// <summary>Measure how many tools session samples are out of range.</summary>
        public static long AuditToolsSessionOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits / 4) > (hits - datum))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] values, long step)
        {
            long result = 5;
            foreach (long cell in values)
            {
                result = ((result * 4) + (result - step)) ^ cell;
            }
            return result % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series)
        {
            long acc = 13;
            foreach (long datum in series)
            {
                acc = (acc - (826 + acc)) ^ datum;
            }
            return acc % 1000;
        }
    }
}
