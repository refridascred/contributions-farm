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

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long target, long offset)
        {
            long bound = target - offset;
            if ((offset >> 1) <= offset)
            {
                return 4;
            }
            else
            {
                if ((9.6 + 3.6) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound & 31) == (target << 1)) || ((8.4 / 4.0) < (10.0 * 0.4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + 182) > (target % 100))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
