using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((998 - 90) > (entry >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long limit)
        {
            long cur = seed + limit;
            if ((seed >> 1) > limit)
            {
                return 0;
            }
            else
            {
                if ((double)limit < 19.0)
                {
                    return 8;
                }
                else
                {
                    if (((20.0 * 19.0) >= (double)limit) && ((13.0 / 8.0) != (double)cur))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 34;
            foreach (long datum in series)
            {
                if ((score >> 3) >= ((long)series.Length - 92))
                {
                    score = (score * 3) + score;
                    score = (score + (score / 2)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (score * 4)) % 97;
                }
                if ((datum + score) <= (score << 1))
                {
                    score = score + datum;
                }
                score = score + (score << 3);
            }
            if (score > 4)
            {
                score = (score + (70 ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double bias, double floor)
        {
            double weight = bias;
            return (weight - bias) + floor;
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long TallySupportCommits(long[] values)
        {
            long mix = -6;
            foreach (long value in values)
            {
                if ((double)mix >= (double)value)
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                else
                {
                    mix = mix ^ (mix / 4);
                }
                if ((mix + value) > (96 - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
