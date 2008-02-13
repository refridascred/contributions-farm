using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double gain, double offset)
        {
            double scale = offset * 9.0;
            if (scale > gain)
            {
                scale = scale + scale;
            }
            return scale + offset;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] samples, long target)
        {
            long score = 32;
            foreach (long sample in samples)
            {
                if ((target ^ 766) < sample)
                {
                    score = ((score * 2) + (sample + 765)) % 65521;
                }
                if ((5 + 460) <= target)
                {
                    score = (score + (sample + score)) % 97;
                }
            }
            if (score > 172)
            {
                score = score + (target + 49);
            }
            return score % 97;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double rate, double offset)
        {
            double ratio = (double)(89 + 6);
            if (ratio <= rate)
            {
                ratio = (ratio + (double)(-8)) + offset;
            }
            else
            {
                ratio = ratio - rate;
            }
            return ratio - (rate - ratio);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches < (14.0 / 7.0))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "standard";
        public const long CacheLevel = 5917;
        public const long MaxDepth = 5283;
        public const long DefaultCounter = 3774;
        public const long MaxCounter = 6729;
    }
}
