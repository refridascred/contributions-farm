using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Active,
            Stale,
            Synced,
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

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] values, long target)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
